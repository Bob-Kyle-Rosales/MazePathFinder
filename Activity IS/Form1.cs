﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activity_IS
{
    public class frmMain : Form
    {
        Program m_Maze;
        int[,] m_iMaze;
        int m_iSize = 27;
        int m_iRowDimensions = 13;
        int m_iColDimensions = 10;
        int iSelectedX, iSelectedY;

        private PictureBox pictureBox1;
        private Label lblPath;
        private GroupBox grpAction;
        private RadioButton bDraw;
        private RadioButton bFind;
        private Label lblPathCaption;
        private Button cmdReset;
        private Button button1;
        private Button cmdExit;
        private CheckBox chkDiagonal;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public frmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.bFind = new System.Windows.Forms.RadioButton();
            this.bDraw = new System.Windows.Forms.RadioButton();
            this.lblPathCaption = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.chkDiagonal = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 279);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(472, 208);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(128, 16);
            this.lblPath.TabIndex = 3;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.bFind);
            this.grpAction.Controls.Add(this.bDraw);
            this.grpAction.Location = new System.Drawing.Point(472, 16);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(120, 104);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action";
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(8, 64);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(104, 24);
            this.bFind.TabIndex = 1;
            this.bFind.Text = "Find Path";
            this.bFind.CheckedChanged += new System.EventHandler(this.bFind_CheckedChanged);
            // 
            // bDraw
            // 
            this.bDraw.Checked = true;
            this.bDraw.Location = new System.Drawing.Point(8, 24);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(104, 24);
            this.bDraw.TabIndex = 0;
            this.bDraw.TabStop = true;
            this.bDraw.Text = "Draw Walls";
            this.bDraw.CheckedChanged += new System.EventHandler(this.bDraw_CheckedChanged);
            // 
            // lblPathCaption
            // 
            this.lblPathCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathCaption.Location = new System.Drawing.Point(472, 192);
            this.lblPathCaption.Name = "lblPathCaption";
            this.lblPathCaption.Size = new System.Drawing.Size(100, 16);
            this.lblPathCaption.TabIndex = 5;
            this.lblPathCaption.Text = "Current Path";
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(472, 248);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(104, 24);
            this.cmdReset.TabIndex = 6;
            this.cmdReset.Text = "&Reset Maze";
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "&About";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(472, 328);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(104, 24);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // chkDiagonal
            // 
            this.chkDiagonal.Location = new System.Drawing.Point(472, 144);
            this.chkDiagonal.Name = "chkDiagonal";
            this.chkDiagonal.Size = new System.Drawing.Size(112, 24);
            this.chkDiagonal.TabIndex = 9;
            this.chkDiagonal.Text = "Allow Diagonals";
            this.chkDiagonal.CheckedChanged += new System.EventHandler(this.chkDiagonal_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(403, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BFS";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(403, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 60);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "GBFS";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(608, 381);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkDiagonal);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.lblPathCaption);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Maze Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
            m_Maze = new Program(m_iRowDimensions, m_iColDimensions);
            this.pictureBox1.Size = new Size(m_iColDimensions *m_iSize, m_iRowDimensions * m_iSize);
            m_iMaze = m_Maze.GetMaze;
            this.lblPath.Visible = false;
            this.lblPathCaption.Visible = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            for (int i = 0; i < m_iRowDimensions; i++)
                for (int j = 0; j < m_iColDimensions; j++)
                {
                    // print grids
                    myGraphics.DrawRectangle(new Pen(Color.Black), j * m_iSize, i * m_iSize, m_iSize, m_iSize);
                    myGraphics.DrawString("" + (j+1 + (i * 10)), new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), j * m_iSize, i * m_iSize);
                    // print walls
                    if (m_iMaze[i, j] == 1)
                    {
                        myGraphics.FillRectangle(new SolidBrush(Color.DarkGray), j * m_iSize + 1, i * m_iSize + 1, m_iSize - 1, m_iSize - 1);
                        myGraphics.DrawString("X", new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), j * m_iSize+8, i * m_iSize+6);

                    }
                    //print path
                    if (m_iMaze[i, j] == 100)
                        myGraphics.FillRectangle(new SolidBrush(Color.PeachPuff), j * m_iSize + 1, i * m_iSize + 1, m_iSize - 1, m_iSize - 1);
                }
            //print ball
            myGraphics.FillEllipse(new SolidBrush(Color.Tomato), this.iSelectedX * m_iSize + 5, this.iSelectedY * m_iSize + 5, m_iSize - 10, m_iSize - 10);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int iX = e.X / m_iSize;
            int iY = e.Y / m_iSize;
            if (iX < m_iColDimensions && iX >= 0 && iY < m_iRowDimensions && iY >= 0)
            {
                if (this.bDraw.Checked == true)
                {
                    m_iMaze = m_Maze.GetMaze;
                    if (m_iMaze[iY, iX] == 0)
                        m_iMaze[iY, iX] = 1;
                    else
                        m_iMaze[iY, iX] = 0;
                    this.Refresh();
                }
                else
                {
                    if (m_iMaze[iY, iX] == 100) //if path exists
                    {
                        //move step by step until the required position is achieved
                        while (this.iSelectedX != iX || this.iSelectedY != iY)
                        {
                            m_iMaze[this.iSelectedY, this.iSelectedX] = 0;

                            if (this.iSelectedX - 1 >= 0 && this.iSelectedX - 1 < m_iColDimensions && m_iMaze[this.iSelectedY, this.iSelectedX - 1] == 100)
                                this.iSelectedX--;
                            else if (this.iSelectedX + 1 >= 0 && this.iSelectedX + 1 < m_iColDimensions && m_iMaze[this.iSelectedY, this.iSelectedX + 1] == 100)
                                this.iSelectedX++;
                            else if (this.iSelectedY - 1 >= 0 && this.iSelectedY - 1 < m_iRowDimensions && m_iMaze[this.iSelectedY - 1, this.iSelectedX] == 100)
                                this.iSelectedY--;
                            else if (this.iSelectedY + 1 >= 0 && this.iSelectedY + 1 < m_iRowDimensions && m_iMaze[this.iSelectedY + 1, this.iSelectedX] == 100)
                                this.iSelectedY++;

                            // move diagonal
                            else if (this.iSelectedY + 1 >= 0 && this.iSelectedY + 1 < m_iRowDimensions && this.iSelectedX + 1 >= 0 && this.iSelectedX + 1 < m_iColDimensions && m_iMaze[this.iSelectedY + 1, this.iSelectedX + 1] == 100)
                            { this.iSelectedX++; this.iSelectedY++; }
                            else if (this.iSelectedY - 1 >= 0 && this.iSelectedY - 1 < m_iRowDimensions && this.iSelectedX + 1 >= 0 && this.iSelectedX + 1 < m_iColDimensions && m_iMaze[this.iSelectedY - 1, this.iSelectedX + 1] == 100)
                            { this.iSelectedX++; this.iSelectedY--; }
                            else if (this.iSelectedY + 1 >= 0 && this.iSelectedY + 1 < m_iRowDimensions && this.iSelectedX - 1 >= 0 && this.iSelectedX - 1 < m_iColDimensions && m_iMaze[this.iSelectedY + 1, this.iSelectedX - 1] == 100)
                            { this.iSelectedX--; this.iSelectedY++; }
                            else if (this.iSelectedY - 1 >= 0 && this.iSelectedY - 1 < m_iRowDimensions && this.iSelectedX - 1 >= 0 && this.iSelectedX - 1 < m_iColDimensions && m_iMaze[this.iSelectedY - 1, this.iSelectedX - 1] == 100)
                            { this.iSelectedX--; this.iSelectedY--; }

                            this.Refresh();
                        }
                    }
                }

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int iY = e.Y / m_iSize;
            int iX = e.X / m_iSize;
            if (iX < m_iColDimensions && iX >= 0 && iY < m_iRowDimensions && iY >= 0)
            {
                m_iMaze = m_Maze.GetMaze;
                if (this.bDraw.Checked == false)
                {
                    int[,] iSolvedMaze = m_Maze.FindPath(iSelectedY, iSelectedX, iY, iX, radioButton1.Checked);
                    if (iSolvedMaze != null)
                    {
                        m_iMaze = iSolvedMaze;
                        this.lblPath.Text = "" + iSelectedY + "," + iSelectedX + " to " + iY + "," + iX;
                    }
                    else
                        this.lblPath.Text = "No Path Found";
                    this.Refresh();
                }
            }
        }

        private void bDraw_CheckedChanged(object sender, System.EventArgs e)
        {
            m_iMaze = m_Maze.GetMaze;
            this.lblPath.Visible = false;
            this.lblPathCaption.Visible = false;
            this.Refresh();
        }

        private void bFind_CheckedChanged(object sender, System.EventArgs e)
        {
            this.m_Maze.AllowDiagonals = this.chkDiagonal.Checked;
            this.lblPath.Visible = true;
            this.lblPathCaption.Visible = true;
        }

        private void cmdReset_Click(object sender, System.EventArgs e)
        {
            m_Maze = new Activity_IS.Program(m_iRowDimensions, m_iColDimensions);
            m_Maze.AllowDiagonals = this.chkDiagonal.Checked;
            m_iMaze = m_Maze.GetMaze;
            this.Refresh();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            MessageBox.Show(
              " Maze Solver Demo" +
            "\n              by" +
            "\n Syed Mehroz Alam" +
            "\n Email: smehrozalam@yahoo.com" +
            "\n Homepage: Programming Home" +
            "\n URL: http://www.geocities.com/smehrozalam/" +
            "\n\n Visit my site to get other programs by me"
            , "About this program");
        }

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chkDiagonal_CheckedChanged(object sender, System.EventArgs e)
        {
            m_Maze.AllowDiagonals = chkDiagonal.Checked;
        }

        private RadioButton radioButton1;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private RadioButton radioButton2;
    }
}
