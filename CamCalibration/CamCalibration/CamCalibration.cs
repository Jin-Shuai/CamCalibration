using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace CamCalibration
{
    //定义相机标定参数
    public class CamCaliParm
    {
        //定义相机内参
        //定义镜头焦距   远心镜头焦距为0 
        public double m_Focus;
        //定义相机畸变系数
        public double m_Kappa;
        //定义相机相元大小
        public double m_Sx;
        public double m_Sy;
        //定义图像中心中标
        public double m_Cx;
        public double m_Cy;
        //定义图像宽度 高度
        public int m_ImgWidth;
        public int m_ImgHeight;

        //定义相机内参数组
        public HTuple m_CamParIn = null;

        //定义相机句柄
        public HTuple m_AcqHandle;

        //定义标定参数
        //定义标定句柄
        public HTuple m_CalibDataID;
        //定义标定板轮廓
        public HObject m_CalibContours;
        //定义标定板标定点
        public HObject m_CalibCross;

        //定义标定数组参数
        public HTuple m_CamParam = null;

        //定义校正图像
        public HObject m_MapImage;

        //设置相机和标定板参数
        //设置标定板类型
        public HTuple m_CalibSetup;
        //设置相机类型
        public HTuple m_CameraType;
        //设置标定板描述文件
        public HTuple m_CalTabDescrFile;
       
        public CamCaliParm()
        {
            m_Focus = 0.00219846;
            m_Kappa = -78129.2;

            m_Sx = 5.5e-06;
            m_Sy = 5.5e-06;

            m_Cx = 320;
            m_Cy = 240;

            m_ImgWidth = 640;
            m_ImgHeight = 480;

            m_CamParIn = new HTuple();
            m_CamParIn[0] = m_Focus;
            m_CamParIn[1] = m_Kappa;
            m_CamParIn[2] = m_Sx;
            m_CamParIn[3] = m_Sy;
            m_CamParIn[4] = m_Cx;
            m_CamParIn[5] = m_Cy;
            m_CamParIn[6] = m_ImgWidth;
            m_CamParIn[7] = m_ImgHeight;

            m_AcqHandle = -1;
            m_CalibDataID = -1;
            HOperatorSet.GenEmptyObj(out m_CalibContours);
            HOperatorSet.GenEmptyObj(out m_CalibCross);
            HOperatorSet.GenEmptyObj(out m_MapImage);

            m_CalibSetup = "calibration_object";
            m_CameraType = "area_scan_division";
            m_CalTabDescrFile = "caltab_big.descr";
        }
    }

    //定义公用图像和区域变量
    public class ImageRegion
    {
        //定义图像
        public HObject m_Image1;
        public HObject m_Image2;
        public HObject m_Image3;
        public HObject m_Image4;
        //定义区域
        public HObject m_Region1;
        public HObject m_Region2;
        public HObject m_Region3;
        public HObject m_Region4;

        public ImageRegion()
        {
            HOperatorSet.GenEmptyObj(out m_Image1);
            HOperatorSet.GenEmptyObj(out m_Image2);
            HOperatorSet.GenEmptyObj(out m_Image3);
            HOperatorSet.GenEmptyObj(out m_Image4);

            HOperatorSet.GenEmptyObj(out m_Region1);
            HOperatorSet.GenEmptyObj(out m_Region2);
            HOperatorSet.GenEmptyObj(out m_Region3);
            HOperatorSet.GenEmptyObj(out m_Region4);
        }
    }

    //定义文件保存路劲
    public class SavePath
    {
        //图像保存路径
        public string m_SavePath;
        //标定图像路径
        public string m_CalibPath;
        //配置文件路劲
        public string m_IniPath;
        //相机内参数组
        public string m_CamParInPath;

        public SavePath()
        {
            m_SavePath = "F:/Image/";
            m_CalibPath = "F:/Image/";
            m_IniPath = Application.StartupPath + "//Set.ini";
            m_CamParInPath = Application.StartupPath + "//CamParIn.ini";
        }
    }

    //定义2个标定线程
    public class ThreadCalibration
    {
        //定义线程启动标志位
        public bool m_bBusy1;
        public bool m_bBusy2;

        //定义线程
        public Thread m_GrabThread1;
        public Thread m_GrabThread2;

        public ThreadCalibration()
        {
            m_bBusy1 = false;
            m_bBusy2 = false;
        }
    }

    public class CamCalibration
    {
        #region //A00 单例模式
        private static CamCalibration _instance = null;
        public static CamCalibration Instance()
        {
            if (_instance == null)
            {
                _instance = new CamCalibration();
            }
            return _instance;
        }
        #endregion

        #region //A01 Ini文件读写
        //声明读写INI文件的API函数  
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                    int size, string filePath);
        //复制内存
        [DllImport("Kernel32.dll")]
        private static extern void CopyMemory(int dest, int source, int size);

        //保存参数到ini文件  
        public void IniWriteValue(string Section, string Key, string Value, string Path)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //读取ini文件中的参数   
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
            return temp.ToString();
        }
        #endregion

        #region //实例化对象
        public CamCaliParm CamCaliParm = new CamCaliParm();
        public ImageRegion ImageRegion = new ImageRegion();
        public SavePath SavePath = new SavePath();
        public ThreadCalibration ThreadCalibration = new ThreadCalibration();

        #endregion
        public void CalibrationImage(HObject ho_Image, out HObject ho_ImageRectified, HTuple hv_CamParIn, out HTuple hv_CamParOut)
        {
            HOperatorSet.GenEmptyObj(out ho_ImageRectified);
            HOperatorSet.ChangeRadialDistortionCamPar("adaptive", hv_CamParIn, 0, out hv_CamParOut);
            ho_ImageRectified.Dispose();
            HOperatorSet.ChangeRadialDistortionImage(ho_Image, ho_Image, out ho_ImageRectified, hv_CamParIn, hv_CamParOut);
            return;
        }

        public void ShowImage(HObject Image, HTuple HalconWindowID)
        {
            //记录图片显示的宽度、高度
            HTuple Width, Heigth;
            //清屏
            HOperatorSet.ClearWindow(HalconWindowID);
            //获取图片长度、宽度
            HOperatorSet.GetImageSize(Image, out Width, out Heigth);
            //设置显示区域
            HOperatorSet.SetPart(HalconWindowID, 0, 0, Heigth, Width);
            //显示图片
            HOperatorSet.DispObj(Image, HalconWindowID);
        }

        public void CamFramegrabber(string ImagePath,HTuple hWindowID,out HTuple AcqHandle)
        {//创建相机句柄
            HOperatorSet.SetDraw(hWindowID, "margin");
            HOperatorSet.OpenFramegrabber("File", -1, -1, -1, -1, -1, -1, "default", -1,
                                          "default", -1, "default", ImagePath, "default", -1, -1, out AcqHandle);
        }

        public  int GetFilesCount(DirectoryInfo dirInfo)
        {//对文件夹里的图像数量计数
            int totalFile = 0;
            totalFile += dirInfo.GetFiles().Length;//获取全部文件
            //totalFile += dirInfo.GetFiles("*.bmp").Length;//获取某种格式
            foreach (System.IO.DirectoryInfo subdir in dirInfo.GetDirectories())
            {
                totalFile += GetFilesCount(subdir);
            }
            return totalFile;
        }

        public void CreateCalibrationID(HTuple hv_CalibSetup, HTuple hv_CameraType, HTuple hv_CamParIn,
                                        HTuple hv_CalTabDescrFile, out HTuple hv_CalibDataID)
        {
            // Initialize local and output iconic variables 
            HOperatorSet.CreateCalibData(hv_CalibSetup, 1, 1, out hv_CalibDataID);
            HOperatorSet.SetCalibDataCamParam(hv_CalibDataID, 0, hv_CameraType, hv_CamParIn);
            HOperatorSet.SetCalibDataCalibObject(hv_CalibDataID, 0, hv_CalTabDescrFile);

            return;
        }

        public void FindCalibration(HObject ho_Image, out HObject ho_Contours, out HObject ho_Cross,
            HTuple hv_CalibDataID, HTuple hv_Index)
        {
            // Local control variables 

            HTuple hv_StartCamPar = null, hv_Row = null;
            HTuple hv_Column = null, hv_index = null, hv_Pose = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Contours);
            HOperatorSet.GenEmptyObj(out ho_Cross);
            HOperatorSet.FindCalibObject(ho_Image, hv_CalibDataID, 0, 0, hv_Index - 1, new HTuple(),
                new HTuple());
            HOperatorSet.GetCalibData(hv_CalibDataID, "camera", 0, "init_params", out hv_StartCamPar);
            HOperatorSet.GetCalibDataObservPoints(hv_CalibDataID, 0, 0, hv_Index - 1, out hv_Row,
                out hv_Column, out hv_index, out hv_Pose);
            ho_Contours.Dispose();
            HOperatorSet.GetCalibDataObservContours(out ho_Contours, hv_CalibDataID, "caltab",
                0, 0, hv_Index - 1);
            ho_Cross.Dispose();
            HOperatorSet.GenCrossContourXld(out ho_Cross, hv_Row, hv_Column, 36, 45);

            return;
        }

        public void GetCalibData(out HObject ho_Maps, HTuple hv_CalibDataID, out HTuple hv_CamParam)
        {
            // Local control variables 
            HTuple hv_Error = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Maps);
            HOperatorSet.CalibrateCameras(hv_CalibDataID, out hv_Error);
            HOperatorSet.GetCalibData(hv_CalibDataID, "camera", 0, "params", out hv_CamParam);
            ho_Maps.Dispose();
            HOperatorSet.GenEmptyObj(out ho_Maps);

            return;
        }

     
        public void GetMapsImage(HObject ho_Maps, out HObject ho_MapsOut, HTuple hv_CalibDataID,
                                 HTuple hv_Index, HTuple hv_CamParam)
        {
            // Stack for temporary objects 
            HObject[] OTemp = new HObject[20];

            // Local iconic variables 

            HObject ho_MapSingle;

            // Local control variables 

            HTuple hv_Pose = null, hv_PoseNewOrigin = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_MapsOut);
            HOperatorSet.GenEmptyObj(out ho_MapSingle);
            try
            {
                ho_MapsOut.Dispose();
                ho_MapsOut = ho_Maps.CopyObj(1, -1);
                HOperatorSet.GetCalibData(hv_CalibDataID, "calib_obj_pose", (new HTuple(0)).TupleConcat(
                    hv_Index - 1), "pose", out hv_Pose);
                HOperatorSet.SetOriginPose(hv_Pose, -1.125, -1.0, 0, out hv_PoseNewOrigin);
                //Generate map
                ho_MapSingle.Dispose();
                HOperatorSet.GenImageToWorldPlaneMap(out ho_MapSingle, hv_CamParam, hv_PoseNewOrigin,
                    768, 576, 900, 800, 0.0025, "bilinear");
                {
                    HObject ExpTmpOutVar_0;
                    HOperatorSet.ConcatObj(ho_MapsOut, ho_MapSingle, out ExpTmpOutVar_0);
                    ho_MapsOut.Dispose();
                    ho_MapsOut = ExpTmpOutVar_0;
                }
                ho_MapSingle.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_MapSingle.Dispose();

                throw HDevExpDefaultException;
            }
        }





    }
}
