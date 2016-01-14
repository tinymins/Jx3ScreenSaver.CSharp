using System;
using System.Threading;
using System.Windows.Forms;

namespace ScreenSaver
{
    public class DotNETScreenSaver
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].ToLower().Trim().Substring(0, 2) == "/c")
                {
                    MessageBox.Show(
                        "����[����@�ν���] x 1��",
                        "���Թ�����?��Ե������?����������?��û��Ϲ��ɶ?",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (MessageBox.Show(
                        "��ǰ�汾: " + Application.ProductVersion.ToString() + "\n\n�Ƿ�鿴���°汾?",
                        "������", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                        System.Diagnostics.Process.Start("http://zhaiyiming.com/index.php/jx3-screen-saver/?ver=" + Application.ProductVersion.ToString());
                }
                else if (args[0].ToLower() == "/s")
                {
                    System.Windows.Forms.Application.Run(new ScreenSaverForm());
                }
            }
            else
            {
                System.Windows.Forms.Application.Run(new ScreenSaverForm());
            }
        }
    }
}
