namespace CamCalibration
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.nudImgHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudImgWidth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCx = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudKappa = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFocus = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCaIibImg = new System.Windows.Forms.Button();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCalibrationPath = new System.Windows.Forms.TextBox();
            this.cbCalTabDescrFile = new System.Windows.Forms.ComboBox();
            this.cbCameraType = new System.Windows.Forms.ComboBox();
            this.cbCalibSetup = new System.Windows.Forms.ComboBox();
            this.btnCalibrationImg = new System.Windows.Forms.Button();
            this.btnCalibrationPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hWindow1 = new HalconDotNet.HWindowControl();
            this.hWindow2 = new HalconDotNet.HWindowControl();
            this.hWindow3 = new HalconDotNet.HWindowControl();
            this.hWindow4 = new HalconDotNet.HWindowControl();
            this.btnMap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKappa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocus)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.31788F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.68212F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1523, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(799, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 541);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相机标定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetting);
            this.groupBox2.Controls.Add(this.nudImgHeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudImgWidth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudCy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudCx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudSy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudSx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudKappa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudFocus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入相机内参";
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(488, 108);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(219, 29);
            this.btnSetting.TabIndex = 16;
            this.btnSetting.Text = "保存设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // nudImgHeight
            // 
            this.nudImgHeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudImgHeight.Location = new System.Drawing.Point(364, 107);
            this.nudImgHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImgHeight.Name = "nudImgHeight";
            this.nudImgHeight.Size = new System.Drawing.Size(97, 25);
            this.nudImgHeight.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(254, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "图像高度:";
            // 
            // nudImgWidth
            // 
            this.nudImgWidth.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudImgWidth.Location = new System.Drawing.Point(142, 107);
            this.nudImgWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImgWidth.Name = "nudImgWidth";
            this.nudImgWidth.Size = new System.Drawing.Size(97, 25);
            this.nudImgWidth.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(15, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "图像宽度:";
            // 
            // nudCy
            // 
            this.nudCy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudCy.Location = new System.Drawing.Point(610, 74);
            this.nudCy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCy.Name = "nudCy";
            this.nudCy.Size = new System.Drawing.Size(97, 25);
            this.nudCy.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(484, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cy(坐标):";
            // 
            // nudCx
            // 
            this.nudCx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudCx.Location = new System.Drawing.Point(364, 74);
            this.nudCx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCx.Name = "nudCx";
            this.nudCx.Size = new System.Drawing.Size(97, 25);
            this.nudCx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(254, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cx(坐标):";
            // 
            // nudSy
            // 
            this.nudSy.DecimalPlaces = 1;
            this.nudSy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudSy.Location = new System.Drawing.Point(144, 74);
            this.nudSy.Name = "nudSy";
            this.nudSy.Size = new System.Drawing.Size(97, 25);
            this.nudSy.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sy像元(um):";
            // 
            // nudSx
            // 
            this.nudSx.DecimalPlaces = 1;
            this.nudSx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudSx.Location = new System.Drawing.Point(610, 39);
            this.nudSx.Name = "nudSx";
            this.nudSx.Size = new System.Drawing.Size(97, 25);
            this.nudSx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(484, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sx像元(um):";
            // 
            // nudKappa
            // 
            this.nudKappa.DecimalPlaces = 2;
            this.nudKappa.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudKappa.Location = new System.Drawing.Point(364, 39);
            this.nudKappa.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKappa.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudKappa.Name = "nudKappa";
            this.nudKappa.Size = new System.Drawing.Size(97, 25);
            this.nudKappa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(254, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "畸变系数:";
            // 
            // nudFocus
            // 
            this.nudFocus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudFocus.Location = new System.Drawing.Point(142, 39);
            this.nudFocus.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFocus.Name = "nudFocus";
            this.nudFocus.Size = new System.Drawing.Size(97, 25);
            this.nudFocus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "焦距(mm):";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCaIibImg);
            this.tabPage1.Controls.Add(this.btnOpenImg);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "桶型枕型畸变校正";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCaIibImg
            // 
            this.btnCaIibImg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCaIibImg.Location = new System.Drawing.Point(163, 15);
            this.btnCaIibImg.Name = "btnCaIibImg";
            this.btnCaIibImg.Size = new System.Drawing.Size(112, 40);
            this.btnCaIibImg.TabIndex = 1;
            this.btnCaIibImg.Text = "校正图像";
            this.btnCaIibImg.UseVisualStyleBackColor = true;
            this.btnCaIibImg.Click += new System.EventHandler(this.btnCaIibImg_Click);
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenImg.Location = new System.Drawing.Point(18, 15);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(112, 40);
            this.btnOpenImg.TabIndex = 0;
            this.btnOpenImg.Text = "打开图像";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnMap);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbCalibrationPath);
            this.tabPage2.Controls.Add(this.cbCalTabDescrFile);
            this.tabPage2.Controls.Add(this.cbCameraType);
            this.tabPage2.Controls.Add(this.cbCalibSetup);
            this.tabPage2.Controls.Add(this.btnCalibrationImg);
            this.tabPage2.Controls.Add(this.btnCalibrationPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "垂直度校正";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(19, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "选取标定图像:";
            // 
            // tbCalibrationPath
            // 
            this.tbCalibrationPath.Location = new System.Drawing.Point(197, 15);
            this.tbCalibrationPath.Name = "tbCalibrationPath";
            this.tbCalibrationPath.Size = new System.Drawing.Size(364, 34);
            this.tbCalibrationPath.TabIndex = 7;
            // 
            // cbCalTabDescrFile
            // 
            this.cbCalTabDescrFile.FormattingEnabled = true;
            this.cbCalTabDescrFile.Items.AddRange(new object[] {
            "caltab_big.descr",
            "calplate.cpd",
            "calplate_20mm.cpd",
            "calplate_40mm.cpd",
            "calplate_80mm.cpd",
            "caltab.desc",
            "caltab_160mm.cpd"});
            this.cbCalTabDescrFile.Location = new System.Drawing.Point(197, 184);
            this.cbCalTabDescrFile.Name = "cbCalTabDescrFile";
            this.cbCalTabDescrFile.Size = new System.Drawing.Size(484, 31);
            this.cbCalTabDescrFile.TabIndex = 6;
            this.cbCalTabDescrFile.Text = "caltab_big.descr";
            // 
            // cbCameraType
            // 
            this.cbCameraType.FormattingEnabled = true;
            this.cbCameraType.Items.AddRange(new object[] {
            "area_scan_division",
            "area_scan_polynomial",
            "area_scan_telecentric_division",
            "area_scan_telecentric_polynomial",
            "area_scan_telecentric_tilt_division",
            "area_scan_telecentric_tilt_polynomial",
            "area_scan_tilt_division",
            "area_scan_tilt_polynomial",
            "line_scan"});
            this.cbCameraType.Location = new System.Drawing.Point(197, 128);
            this.cbCameraType.Name = "cbCameraType";
            this.cbCameraType.Size = new System.Drawing.Size(484, 31);
            this.cbCameraType.TabIndex = 5;
            this.cbCameraType.Text = "area_scan_division";
            // 
            // cbCalibSetup
            // 
            this.cbCalibSetup.FormattingEnabled = true;
            this.cbCalibSetup.Items.AddRange(new object[] {
            "calibration_object",
            "hand_eye_moving_cam",
            "hand_eye_scara_moving_cam",
            "hand_eye_scara_stationary_cam",
            "hand_eye_stationary_cam"});
            this.cbCalibSetup.Location = new System.Drawing.Point(197, 72);
            this.cbCalibSetup.Name = "cbCalibSetup";
            this.cbCalibSetup.Size = new System.Drawing.Size(484, 31);
            this.cbCalibSetup.TabIndex = 4;
            this.cbCalibSetup.Text = "calibration_object";
            // 
            // btnCalibrationImg
            // 
            this.btnCalibrationImg.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalibrationImg.Location = new System.Drawing.Point(19, 244);
            this.btnCalibrationImg.Name = "btnCalibrationImg";
            this.btnCalibrationImg.Size = new System.Drawing.Size(188, 40);
            this.btnCalibrationImg.TabIndex = 3;
            this.btnCalibrationImg.Text = "读取标定图像";
            this.btnCalibrationImg.UseVisualStyleBackColor = true;
            this.btnCalibrationImg.Click += new System.EventHandler(this.btnCalibrationImg_Click);
            // 
            // btnCalibrationPath
            // 
            this.btnCalibrationPath.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalibrationPath.Location = new System.Drawing.Point(567, 14);
            this.btnCalibrationPath.Name = "btnCalibrationPath";
            this.btnCalibrationPath.Size = new System.Drawing.Size(114, 36);
            this.btnCalibrationPath.TabIndex = 2;
            this.btnCalibrationPath.Text = "...";
            this.btnCalibrationPath.UseVisualStyleBackColor = true;
            this.btnCalibrationPath.Click += new System.EventHandler(this.btnCalibrationPath_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.hWindow1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hWindow2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.hWindow3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.hWindow4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 541);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // hWindow1
            // 
            this.hWindow1.BackColor = System.Drawing.Color.Black;
            this.hWindow1.BorderColor = System.Drawing.Color.Black;
            this.hWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow1.Location = new System.Drawing.Point(3, 3);
            this.hWindow1.Name = "hWindow1";
            this.hWindow1.Size = new System.Drawing.Size(389, 264);
            this.hWindow1.TabIndex = 0;
            this.hWindow1.WindowSize = new System.Drawing.Size(389, 264);
            // 
            // hWindow2
            // 
            this.hWindow2.BackColor = System.Drawing.Color.Black;
            this.hWindow2.BorderColor = System.Drawing.Color.Black;
            this.hWindow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow2.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow2.Location = new System.Drawing.Point(398, 3);
            this.hWindow2.Name = "hWindow2";
            this.hWindow2.Size = new System.Drawing.Size(389, 264);
            this.hWindow2.TabIndex = 1;
            this.hWindow2.WindowSize = new System.Drawing.Size(389, 264);
            // 
            // hWindow3
            // 
            this.hWindow3.BackColor = System.Drawing.Color.Black;
            this.hWindow3.BorderColor = System.Drawing.Color.Black;
            this.hWindow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow3.Location = new System.Drawing.Point(3, 273);
            this.hWindow3.Name = "hWindow3";
            this.hWindow3.Size = new System.Drawing.Size(389, 265);
            this.hWindow3.TabIndex = 2;
            this.hWindow3.WindowSize = new System.Drawing.Size(389, 265);
            // 
            // hWindow4
            // 
            this.hWindow4.BackColor = System.Drawing.Color.Black;
            this.hWindow4.BorderColor = System.Drawing.Color.Black;
            this.hWindow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow4.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow4.Location = new System.Drawing.Point(398, 273);
            this.hWindow4.Name = "hWindow4";
            this.hWindow4.Size = new System.Drawing.Size(389, 265);
            this.hWindow4.TabIndex = 3;
            this.hWindow4.WindowSize = new System.Drawing.Size(389, 265);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(271, 244);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(188, 40);
            this.btnMap.TabIndex = 14;
            this.btnMap.Text = "生成校正图像";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(19, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "标定类型:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(19, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "相机类型:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(19, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "标定板描述文件:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "图像标定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKappa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocus)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudImgHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudImgWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudKappa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private HalconDotNet.HWindowControl hWindow1;
        private HalconDotNet.HWindowControl hWindow2;
        private HalconDotNet.HWindowControl hWindow3;
        private HalconDotNet.HWindowControl hWindow4;
        private System.Windows.Forms.Button btnCaIibImg;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.ComboBox cbCalTabDescrFile;
        private System.Windows.Forms.ComboBox cbCameraType;
        private System.Windows.Forms.ComboBox cbCalibSetup;
        private System.Windows.Forms.Button btnCalibrationImg;
        private System.Windows.Forms.Button btnCalibrationPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCalibrationPath;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

