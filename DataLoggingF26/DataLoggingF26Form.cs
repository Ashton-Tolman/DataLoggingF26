namespace DataLoggingF26
{
    public partial class DataLoggingF26Form : Form
    {
        public DataLoggingF26Form()
        {
            InitializeComponent();
        }

        Queue<int> buffer = new Queue<int>();

        int lastX, lastY;

        void DrawLine(int x, int y)
        {


            Graphics g = DisplayPictureBox.CreateGraphics();    //Where am I drawing
            Pen thePen = new Pen(Color.Green);                  //What am I drawing with
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1024f;

            g.ScaleTransform(sx, -sy);        //Set scale of display reguarless of pixels and fix y direction
            g.TranslateTransform(0, -1024);   //Move drawing origin to bottom left


            g.DrawLine(thePen, lastX, lastY, x, y);

            lastX = x;
            lastY = y;
            //free these resources
            g.Dispose();        //Done with this
            thePen.Dispose();   //Done with this
        }

        void DrawVerticalLine(int x)
        {


            Graphics g = DisplayPictureBox.CreateGraphics();    //Where am I drawing
            Pen thePen = new Pen(Color.Red);                  //What am I drawing with
            float sx = DisplayPictureBox.Width / 100f;
            float sy = DisplayPictureBox.Height / 1024f;

            g.ScaleTransform(sx, -sy);        //Set scale of display reguarless of pixels and fix y direction
            g.TranslateTransform(0, -1024);   //Move drawing origin to bottom left

            thePen.Width = 1;

            g.DrawLine(thePen, x, 0, x, 1024);

            //free these resources
            g.Dispose();        //Done with this
            thePen.Dispose();   //Done with this
        }
        void DrawBuffer()
        {

            //DisplayPictureBox.Refresh(); <--Too slow, gives flicker
            lastX = 0;
            lastY = 0;

            for (int point = 0; point < buffer.Count; point++)
            {
                DrawLine(point, buffer.ElementAt(point));
                DrawVerticalLine(point);
            }
        }

        int GetFakeData()
        {
            Random randy = new Random();
            return randy.Next(1024);

        }

        void GetDataSample()
        {
            if (buffer.Count >= 100)
            {
                buffer.Dequeue();
            }
            buffer.Enqueue(GetFakeData());
        }

        //-----------------------------------------------------------------------------------------
        //
        //Event Handlers Below---------------------------------------------------------------------
        //
        //-----------------------------------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawLine(90,512);

            if (SampleTimer.Enabled)
            {
                SampleTimer.Enabled = false;
            }
            else
            {
                SampleTimer.Enabled = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }

        private void SampleTimer_Tick(object sender, EventArgs e)
        {
            GetDataSample();
            DrawBuffer();
        }
    }
}
