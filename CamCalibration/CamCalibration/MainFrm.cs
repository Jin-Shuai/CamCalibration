using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using System.Threading;
using System.IO;

namespace CamCalibration
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        //实例化相关类
        CamCalibration CamCalib = new CamCalibration();

        private void btnOpenImg_Click(object sender, EventArgs e)
        {//打开图像
            OpenFileDialog Dlg = new OpenFileDialog();

            Dlg.Filter = "(*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png";
            Dlg.Multiselect = false;
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //定义图像变量
                    HOperatorSet.GenEmptyObj(out CamCalib.ImageRegion.m_Image1);
                    //打开图像
                    CamCalib.ImageRegion.m_Image1.Dispose();
                    HOperatorSet.ReadImage(out CamCalib.ImageRegion.m_Image1, Dlg.FileName);
                    //获取图像大小并显示全图
                    CamCalib.ShowImage(CamCalib.ImageRegion.m_Image1, hWindow1.HalconWindow);

                    //内存释放
                    Dlg.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("图像打开失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCaIibImg_Click(object sender, EventArgs e)
        {//校正图像
            HTuple m_CamParOut = null;
            CamCalib.CalibrationImage(CamCalib.ImageRegion.m_Image1, out CamCalib.ImageRegion.m_Image2, CamCalib.CamCaliParm.m_CamParIn, out m_CamParOut);
            //获取图像大小并显示全图
            CamCalib.ShowImage(CamCalib.ImageRegion.m_Image2, hWindow2.HalconWindow);
        }

        public void Save_Parameter()
        {//保存设置参数
            CamCalib.IniWriteValue("焦距", "Focus", Convert.ToString(nudFocus.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("畸变系数", "Kappa", Convert.ToString(nudKappa.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("像元大小", "Sx", Convert.ToString(nudSx.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("像元大小", "Sy", Convert.ToString(nudSy.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("中心坐标", "Cx", Convert.ToString(nudCx.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("中心坐标", "Cy", Convert.ToString(nudCy.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("图像尺寸", "ImgWidth", Convert.ToString(nudImgWidth.Value), CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("图像尺寸", "ImgHeight", Convert.ToString(nudImgHeight.Value), CamCalib.SavePath.m_IniPath);

            //相机内参保存到数组
            CamCalib.CamCaliParm.m_CamParIn[0] = (HTuple)nudFocus.Value * (0.00000001);
            CamCalib.CamCaliParm.m_CamParIn[1] = (HTuple)nudKappa.Value * (1);
            CamCalib.CamCaliParm.m_CamParIn[2] = (HTuple)nudSx.Value * (0.000001);
            CamCalib.CamCaliParm.m_CamParIn[3] = (HTuple)nudSy.Value * (0.000001);
            CamCalib.CamCaliParm.m_CamParIn[4] = (HTuple)nudCx.Value * (1);
            CamCalib.CamCaliParm.m_CamParIn[5] = (HTuple)nudCy.Value * (1);
            CamCalib.CamCaliParm.m_CamParIn[6] = (HTuple)nudImgWidth.Value * (1);
            CamCalib.CamCaliParm.m_CamParIn[7] = (HTuple)nudImgHeight.Value * (1);

            HOperatorSet.WriteTuple(CamCalib.CamCaliParm.m_CamParIn, new HTuple(CamCalib.SavePath.m_CamParInPath));

            //垂直度校正
            CamCalib.IniWriteValue("标定图像", "CalibrationPath", tbCalibrationPath.Text, CamCalib.SavePath.m_IniPath);

            CamCalib.IniWriteValue("标定图像", "CalibSetup", cbCalibSetup.Text, CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("标定图像", "CameraType", cbCameraType.Text, CamCalib.SavePath.m_IniPath);
            CamCalib.IniWriteValue("标定图像", "CalTabDescrFile", cbCalTabDescrFile.Text, CamCalib.SavePath.m_IniPath);
        }

        public void Read_Parameter()
        {//读取设置参数
            nudFocus.Value = Convert.ToDecimal(CamCalib.IniReadValue("焦距", "Focus", CamCalib.SavePath.m_IniPath));
            nudKappa.Value = Convert.ToDecimal(CamCalib.IniReadValue("畸变系数", "Kappa", CamCalib.SavePath.m_IniPath));
            nudSx.Value = Convert.ToDecimal(CamCalib.IniReadValue("像元大小", "Sx", CamCalib.SavePath.m_IniPath));
            nudSy.Value = Convert.ToDecimal(CamCalib.IniReadValue("像元大小", "Sy", CamCalib.SavePath.m_IniPath));
            nudCx.Value = Convert.ToDecimal(CamCalib.IniReadValue("中心坐标", "Cx", CamCalib.SavePath.m_IniPath));
            nudCy.Value = Convert.ToDecimal(CamCalib.IniReadValue("中心坐标", "Cy", CamCalib.SavePath.m_IniPath));
            nudImgWidth.Value = Convert.ToDecimal(CamCalib.IniReadValue("图像尺寸", "ImgWidth", CamCalib.SavePath.m_IniPath));
            nudImgHeight.Value = Convert.ToDecimal(CamCalib.IniReadValue("图像尺寸", "ImgHeight", CamCalib.SavePath.m_IniPath));

            //读取相机内参
            HOperatorSet.ReadTuple(new HTuple(CamCalib.SavePath.m_CamParInPath), out CamCalib.CamCaliParm.m_CamParIn);

            //垂直度校正
            tbCalibrationPath.Text = CamCalib.IniReadValue("标定图像", "CalibrationPath", CamCalib.SavePath.m_IniPath);

            cbCalibSetup.Text = CamCalib.IniReadValue("标定图像", "CalibSetup", CamCalib.SavePath.m_IniPath);
            cbCameraType.Text = CamCalib.IniReadValue("标定图像", "CameraType", CamCalib.SavePath.m_IniPath);
            cbCalTabDescrFile.Text = CamCalib.IniReadValue("标定图像", "CalTabDescrFile", CamCalib.SavePath.m_IniPath);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Save_Parameter();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Read_Parameter();
            CamCalib.CamFramegrabber(CamCalib.SavePath.m_CalibPath, hWindow2.HalconWindow, out CamCalib.CamCaliParm.m_AcqHandle);
        }

        public void GrabImageThread1()
        {//线程采图
            while (CamCalib.ThreadCalibration.m_bBusy1)
            {
                try
                {
                    if (CamCalib.CamCaliParm.m_AcqHandle > -1 && CamCalib.CamCaliParm.m_AcqHandle != null)
                    {
                        //获取文件夹中图像数量
                        System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(CamCalib.SavePath.m_CalibPath);
                        int CalibrationNum = CamCalib.GetFilesCount(dirInfo);
                        MessageBox.Show("文件个数为：" + CalibrationNum + "个");
                        for (int i = 1; i <= CalibrationNum; i = i + 1)
                        {
                            //采集图像
                            CamCalib.ImageRegion.m_Image3.Dispose();
                            HOperatorSet.GrabImage(out CamCalib.ImageRegion.m_Image3, CamCalib.CamCaliParm.m_AcqHandle);
                            //获取图像大小并显示全图
                            CamCalib.ShowImage(CamCalib.ImageRegion.m_Image3, hWindow3.HalconWindow);
                            Thread.Sleep(1000);
                            //查找标定板
                            CamCalib.CamCaliParm.m_CalibContours.Dispose();
                            CamCalib.CamCaliParm.m_CalibCross.Dispose();
                            CamCalib.FindCalibration(CamCalib.ImageRegion.m_Image3, out CamCalib.CamCaliParm.m_CalibContours, out CamCalib.CamCaliParm.m_CalibCross, CamCalib.CamCaliParm.m_CalibDataID, i);

                            HOperatorSet.SetColor(hWindow3.HalconWindow, "green");
                            HOperatorSet.DispObj(CamCalib.CamCaliParm.m_CalibContours, hWindow3.HalconWindow);
                            HOperatorSet.SetColor(hWindow3.HalconWindow, "yellow");
                            HOperatorSet.DispObj(CamCalib.CamCaliParm.m_CalibCross, hWindow3.HalconWindow);
                            Thread.Sleep(100);
                        }

                        CamCalib.GetCalibData(out CamCalib.CamCaliParm.m_MapImage, CamCalib.CamCaliParm.m_CalibDataID, out CamCalib.CamCaliParm.m_CamParam);

                        for (int i = 1; i <= CalibrationNum; i = i + 1)
                        {
                            CamCalib.GetMapsImage(CamCalib.CamCaliParm.m_MapImage, out CamCalib.CamCaliParm.m_MapImage, CamCalib.CamCaliParm.m_CalibDataID, i, CamCalib.CamCaliParm.m_CamParam);
                        }
                        HOperatorSet.ClearCalibData(CamCalib.CamCaliParm.m_CalibDataID);
                        Thread.Sleep(100);
                        HOperatorSet.ClearWindow(hWindow3.HalconWindow);
                        HOperatorSet.DispObj(CamCalib.CamCaliParm.m_MapImage, hWindow3.HalconWindow);
                    }
                    CamCalib.ThreadCalibration.m_bBusy1 = false;
                }
                catch (System.Exception)
                {
                    Thread.Sleep(10);
                }
                finally
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            CamCalib.ThreadCalibration.m_GrabThread1.Abort();
        }

        public void GrabImageThread2()
        {//线程采图
            while (CamCalib.ThreadCalibration.m_bBusy2)
            {
                HObject ho_MapSingle = null;
                try
                {
                    //获取文件夹中图像数量
                    System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(CamCalib.SavePath.m_CalibPath);
                    int CalibrationNum = CamCalib.GetFilesCount(dirInfo);
                    MessageBox.Show("文件个数为：" + CalibrationNum + "个");
                    for (int i = 1; i <= CalibrationNum; i = i + 1)
                    {
                        //采集图像
                        CamCalib.ImageRegion.m_Image3.Dispose();
                        HOperatorSet.GrabImage(out CamCalib.ImageRegion.m_Image3, CamCalib.CamCaliParm.m_AcqHandle);
                        HOperatorSet.DispObj(CamCalib.ImageRegion.m_Image3, hWindow4.HalconWindow);
                        //校正图像
                        HOperatorSet.SelectObj(CamCalib.CamCaliParm.m_MapImage, out ho_MapSingle, i);
                        CamCalib.ImageRegion.m_Image4.Dispose();
                        HOperatorSet.MapImage(CamCalib.ImageRegion.m_Image3, ho_MapSingle, out CamCalib.ImageRegion.m_Image4);
                        HOperatorSet.ClearWindow(hWindow4.HalconWindow);
                        //获取图像大小并显示全图
                        CamCalib.ShowImage(CamCalib.ImageRegion.m_Image4, hWindow4.HalconWindow);
                        Thread.Sleep(1000);
                    }
                    CamCalib.ThreadCalibration.m_bBusy2 = false;
                }
                catch (System.Exception)
                {
                    Thread.Sleep(10);
                }
                finally
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            CamCalib.ThreadCalibration.m_GrabThread2.Abort();
        }

        private void btnCalibrationPath_Click(object sender, EventArgs e)
        {//标定图像路劲
            //创建FolderBrowserDialog对象
            FolderBrowserDialog FBDialog = new FolderBrowserDialog();
            //判断是否选择文件夹
            if (FBDialog.ShowDialog() == DialogResult.OK)
            {
                //记录选择的文件夹
                CamCalib.SavePath.m_CalibPath = FBDialog.SelectedPath;
                if (CamCalib.SavePath.m_CalibPath.EndsWith("\\"))
                {
                    tbCalibrationPath.Text = CamCalib.SavePath.m_CalibPath;//显示选择的文件夹
                }
                else
                {
                    tbCalibrationPath.Text = CamCalib.SavePath.m_CalibPath + "\\";//显示选择的文件夹
                }
            }
        }

        private void btnCalibrationImg_Click(object sender, EventArgs e)
        {
            HTuple hv_CamParIn = null;
            hv_CamParIn = new HTuple();
            hv_CamParIn[0] = 0.008;
            hv_CamParIn[1] = 0;
            hv_CamParIn[2] = 0.0000086;
            hv_CamParIn[3] = 0.0000086;
            hv_CamParIn[4] = 384;
            hv_CamParIn[5] = 288;
            hv_CamParIn[6] = 768;
            hv_CamParIn[7] = 576;

            CamCalib.CreateCalibrationID(CamCalib.CamCaliParm.m_CalibSetup, CamCalib.CamCaliParm.m_CameraType, hv_CamParIn, CamCalib.CamCaliParm.m_CalTabDescrFile, out CamCalib.CamCaliParm.m_CalibDataID);
            //CamCalib.CreateCalibrationID(CamCalib.CamCaliParm.m_CalibSetup, CamCalib.CamCaliParm.m_CameraType, CamCalib.CamCaliParm.m_CamParIn, CamCalib.CamCaliParm.m_CalTabDescrFile, out CamCalib.CamCaliParm.m_CalibDataID);

            //创建线程并开始线程
            CamCalib.ThreadCalibration.m_bBusy1 = true;
            //开辟一个线程
            CamCalib.ThreadCalibration.m_GrabThread1 = new Thread(new ThreadStart(GrabImageThread1));
            //开始线程
            CamCalib.ThreadCalibration.m_GrabThread1.Start();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {//生成校正图像
            //创建线程并开始线程
            CamCalib.ThreadCalibration.m_bBusy2 = true;
            //开辟一个线程
            CamCalib.ThreadCalibration.m_GrabThread2 = new Thread(new ThreadStart(GrabImageThread2));
            //开始线程
            CamCalib.ThreadCalibration.m_GrabThread2.Start();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {//窗口关闭事件
            //关闭线程
            CamCalib.ThreadCalibration.m_bBusy1 = false;
            CamCalib.ThreadCalibration.m_bBusy2 = false;
        }
    }

}
