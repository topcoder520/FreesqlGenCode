using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreesqlGenCode
{
    public static class InvokeLoading
    {

        public static async Task ShowLoadingAsync(this Control control,string message,Func<Control,Task> action) {
            FormLoading frmLoading = null;
            try
            {
                Task.Run(() =>
                {
                    if (control.InvokeRequired)
                    {
                        control.Invoke((Action)delegate ()
                        {
                            frmLoading = new FormLoading(message);
                            Common.Console.Log("Req");
                            frmLoading.ShowDialog();
                        });
                    }
                    else
                    {
                        frmLoading = new FormLoading(message);
                        Common.Console.Log("Not Req");
                        frmLoading.ShowDialog();
                    }
                });
                await Task.Run(async () =>
                {
                    await action(control);
                });
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                while (true)
                {
                    if (frmLoading != null)
                    {
                        Common.Console.Log("close");
                        if (control.InvokeRequired)
                        {
                            control.Invoke(() =>
                            {
                                frmLoading?.Close();
                            });
                        }
                        else
                        {
                            frmLoading?.Close();
                        }
                        break;
                    }
                    await Task.Delay(TimeSpan.FromMilliseconds(300));
                }
            }
        }
    }
}
