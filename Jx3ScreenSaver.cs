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
				if (args[0].ToLower().Trim().Substring(0,2) == "/c")
				{
					MessageBox.Show("����[����@�ν���] x 1��", "���Թ�����?��Ե������?����������?��û��Ϲ��ɶ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
