using EmergencySite.ClassLibraries.BusinessLayer.CommanFunctions;
using EmergencySite.ClassLibraries.DataLayer;
using EmergencySite.ClassLibraries.Exception;
using EmergencySite.ClassLibraries.Models.Email;
using EmergencySite.Core.Executors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.ClassLibraries.BusinessLayer.EmailBal
{
    public static class EmailBal
    {
        //private static string userName = "erp.support@sisrtd.com";
        //private static string password = "6I$12xbq";
        //private static string fromName = "WE-SIS";

        /*
            MailBox Table:
            MailType : The mail is sent from which module.

            MailType = 1 : Material Request (MailTypeId = MaterialRequestId).
            MailType = 2 : Site Allocation (MailTypeId = PiuRepairedDetailsId).
            MailType = 3 : PIU Repaired (MailTypeId = PiuRepairedDetailsId).
            MailType = 4 : PIU Complaint (MailTypeId = PIUComplaintId).
            MailType = 5 : Validation Required (MailTypeId = PiuRepairedDetailsId).
            MailType = 6 : Empoyee Attendance (MailTypeId = LoginRid).
            MailType = 7 : Empoyee Plan (MailTypeId = 0).
            MailType = 8 : Alert Mail - Summary Signoff Online (MailTypeId = InvoiceId).
            MailType = 9 : Summary Signoff Online (MailTypeId = InvoiceId).
            MailType = 10 : Customer user credentials (MailTypeId = LoginRid).
            MailType = 11 : Quotation send mail (MailTypeId = QuotationId).
             
        */

        public static DataTable SelectLogin(string loginRid, string departmentId, int inType)
        {
            var arList = new ArrayList();
            var parameter = new SqlParameter("@LoginRid", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(loginRid) ? null : loginRid };
            arList.Add(parameter);

            parameter = new SqlParameter("@DepartmentId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(departmentId) ? null : departmentId };
            arList.Add(parameter);

            parameter = new SqlParameter("@InType", SqlDbType.Int) { Value = inType };
            arList.Add(parameter);

            var oDataLayer = new DataLayerCommanMethod();

            return oDataLayer.ExecProcParameterDataTable(StoreProcedureName.SpSelectLogin, arList);
        }

        public static async Task SendMailFromGmail(EmailERP emailERP, ArrayList toList, ArrayList ccList)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage mailMessage = new MailMessage();

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(emailERP.FromAddress, emailERP.Password);
            smtpClient.Timeout = 20000;
            //var requestCount = 10;

            //mailToObj.From = new MailAddress(Session["UserId"].ToString());
            //mailToObj.To.Add(new MailAddress("dushyant@sysinfra.in"));
            //mailToObj.To.Add(new MailAddress("erp.sysinfra@gmail.com"));
            mailMessage.From = new MailAddress(emailERP.FromAddress, emailERP.FromName);
            //mailMessage.To.Add(new MailAddress(emailERP.ToAddress));

            foreach (string toAddress in toList)
            {
                if (!string.IsNullOrWhiteSpace(toAddress))
                {
                    mailMessage.To.Add(new MailAddress(toAddress));
                }
            }

            foreach (string ccAddress in ccList)
            {
                if (!string.IsNullOrWhiteSpace(ccAddress))
                {
                    mailMessage.CC.Add(new MailAddress(ccAddress));
                }
            }


            //mailMessage.CC.Add(new MailAddress(emailERP.ToAddress));
            mailMessage.Subject = emailERP.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            mailMessage.Body = emailERP.MailBody;
            await smtpClient.SendMailAsync(mailMessage);
        }

        public static DataTable SelectMailBox(int inType, string mailBoxId, int? mailType, string mailTypeId)
        {
            var dbAccess = new DataLayerCommanMethod();
            try
            {
                var arList = new ArrayList();
                var parameter = new SqlParameter("@InType", SqlDbType.Int) { Value = inType };
                arList.Add(parameter);

                parameter = new SqlParameter("@MailBoxId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(mailBoxId) ? null : mailBoxId };
                arList.Add(parameter);

                parameter = new SqlParameter("@MailType", SqlDbType.Int) { Value = mailType };
                arList.Add(parameter);

                parameter = new SqlParameter("@MailTypeId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(mailTypeId) ? null : mailTypeId };
                arList.Add(parameter);

                return dbAccess.ExecProcParameterDataTable(StoreProcedureName.SpSelectMailBox, arList);
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[EmailBal] " + "Methods[SelectMailBox] " +
                                                ex.Message);
            }
        }

        public static bool AddUpdateCronPlan(
                byte inType,
                string cronPlanId,
                string projectId,
                string subject,
                string toAddress,
                string ccAddress,
                string bccAddress,
                DateTime? startDate,
                DateTime? endDate,
                string executedBy
            )
        {
            var arList = new ArrayList();
            var parameter = new SqlParameter("@InType", SqlDbType.Int) { Value = inType };
            arList.Add(parameter);

            parameter = new SqlParameter("@CronPlanId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(cronPlanId) ? null : cronPlanId };
            arList.Add(parameter);

            parameter = new SqlParameter("@ProjectId", SqlDbType.Int) { Value = projectId == "-1" ? null : projectId };
            arList.Add(parameter);

            parameter = new SqlParameter("@Subject", SqlDbType.NVarChar) { Value = string.IsNullOrWhiteSpace(subject) ? null : subject };
            arList.Add(parameter);

            parameter = new SqlParameter("@ToAddress", SqlDbType.NVarChar) { Value = string.IsNullOrWhiteSpace(toAddress) ? null : toAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@CCAddress", SqlDbType.NVarChar) { Value = string.IsNullOrWhiteSpace(ccAddress) ? null : ccAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@BccAddress", SqlDbType.NVarChar) { Value = string.IsNullOrWhiteSpace(bccAddress) ? null : bccAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startDate == null ? null : startDate };
            arList.Add(parameter);

            parameter = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = endDate == null ? null : endDate };
            arList.Add(parameter);

            parameter = new SqlParameter("@ExecutedBy", SqlDbType.Int) { Value = executedBy };
            arList.Add(parameter);

            var dbAccess = new DataLayerCommanMethod();
            try
            {
                var status = dbAccess.ExecuteProcedureWithParameterWithReturn(StoreProcedureName.SpInsertUpdateCronPlan, arList);

                return status > 0;
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[MasterEntryAddUpdate] " + "Methods[AddUpdateSite] " + ex.Message);
            }
        }

        public static bool AddUpdateMailBox(
                int inType,
                string mailBoxId,
                int? mailType,
                string mailTypeId,
                int? medium,
                string fromAddress,
                string toAddress,
                string ccAddress,
                string bccAddress,
                string subject,
                string mailBody,
                string executedBy
            )
        {
            var arList = new ArrayList();
            var parameter = new SqlParameter("@InType", SqlDbType.Int) { Value = inType };
            arList.Add(parameter);

            parameter = new SqlParameter("@MailBoxId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(mailBoxId) ? null : mailBoxId };
            arList.Add(parameter);

            parameter = new SqlParameter("@MailType", SqlDbType.Int) { Value = mailType };
            arList.Add(parameter);

            parameter = new SqlParameter("@MailTypeId", SqlDbType.Int) { Value = string.IsNullOrWhiteSpace(mailTypeId) ? null : mailTypeId };
            arList.Add(parameter);

            parameter = new SqlParameter("@FromAddress", SqlDbType.VarChar) { Value = string.IsNullOrWhiteSpace(fromAddress) ? null : fromAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@ToAddress", SqlDbType.VarChar) { Value = string.IsNullOrWhiteSpace(toAddress) ? null : toAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@CCAddress", SqlDbType.VarChar) { Value = string.IsNullOrWhiteSpace(ccAddress) ? null : ccAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@BccAddress", SqlDbType.VarChar) { Value = string.IsNullOrWhiteSpace(bccAddress) ? null : bccAddress };
            arList.Add(parameter);

            parameter = new SqlParameter("@Subject", SqlDbType.VarChar) { Value = string.IsNullOrWhiteSpace(subject) ? null : subject };
            arList.Add(parameter);

            parameter = new SqlParameter("@MailBody", SqlDbType.NVarChar) { Value = string.IsNullOrWhiteSpace(mailBody) ? null : mailBody };
            arList.Add(parameter);

            parameter = new SqlParameter("@Medium", SqlDbType.Int) { Value = medium };           //Sent from ERP User logged in (Mannual Mode)
            arList.Add(parameter);

            parameter = new SqlParameter("@ExecutedBy", SqlDbType.Int) { Value = executedBy };
            arList.Add(parameter);


            var dbAccess = new DataLayerCommanMethod();
            try
            {
                var status = dbAccess.ExecuteProcedureWithParameterWithReturn(StoreProcedureName.SpInsertUpdateMailBox, arList);

                return status > 0;
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[MasterEntryAddUpdate] " + "Methods[AddUpdateSite] " + ex.Message);
            }
        }

        public static DataTable SelectCronPlan(int inType, string projectId)
        {
            var dbAccess = new DataLayerCommanMethod();
            try
            {
                var arList = new ArrayList();
                var parameter = new SqlParameter("@InType", SqlDbType.Int) { Value = inType };
                arList.Add(parameter);

                parameter = new SqlParameter("@ProjectId", SqlDbType.Int) { Value = projectId == null ? null : projectId };
                arList.Add(parameter);

                return dbAccess.ExecProcParameterDataTable(StoreProcedureName.SpSelectCronPlan, arList);
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[EmailBal] " + "Methods[SelectMailBox] " +
                                                ex.Message);
            }
        }

        public static async Task Exceptions(string message, string executedBy)
        {
            var messageSubject = message.Split('£');
            EmailERP emailERP = new EmailERP
            {
                FromAddress = "erp.support@sisrtd.com",
                Password = "6I$12xbq",
                FromName = "WE-SIS",
                Subject = messageSubject[1],
                MailBody = messageSubject[0] + "[ExecutedBy: " + executedBy + "]"
            };

            var toAddressList = new ArrayList();
            var ccAddressList = new ArrayList();

            toAddressList.Add("erp.sysinfra@gmail.com");
            toAddressList.Add("xenon.9210@gmail.com");
            toAddressList.Add("shoaib@sysinfra.in");

            await SendMailAsync(emailERP, toAddressList, ccAddressList);
        }

        public static async Task<bool> SendMailAsync(
            EmailERP emailERP,
            ArrayList toList,
            ArrayList ccList,
            bool isPersistence = false,
            int? mailType = null,
            string mailTypeId = null,
            int? medium = null,
            string executedBy = null,
            Attachment attachment = null)
        {
            try
            {
                var smtpClient = CreateSmtpClient(emailERP);
                var mailAddressExecutor = CreateMailMessage(emailERP, toList, ccList);
                var mailMessage = mailAddressExecutor.MailMessage;

                await smtpClient.SendMailAsync(mailMessage);

                if (isPersistence)
                    AddUpdateMailBox(
                        0,
                        null,
                        mailType,
                        mailTypeId,
                        medium,
                        emailERP.FromAddress,
                        mailAddressExecutor.To,
                        mailAddressExecutor.CC,
                        mailAddressExecutor.Bcc,
                        emailERP.Subject,
                        emailERP.MailBody,
                        executedBy);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
                throw ex;
            }
        }

        private static SmtpClient CreateSmtpClient(EmailERP emailERP)
        {
            var smtpClient = new SmtpClient();

            smtpClient.Host = "mail.sisrtd.com";
            smtpClient.Port = 2525;

            smtpClient.EnableSsl = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Timeout = 20000;

            smtpClient.Credentials = new NetworkCredential(emailERP.FromAddress, emailERP.Password);

            return smtpClient;
        }

        private static MailAddressExecutor CreateMailMessage(EmailERP emailERP, ArrayList toList, ArrayList ccList, Attachment attachment = null)
        {
            var mailMessage = new MailMessage();
            var mailAddressExecutor = new MailAddressExecutor();

            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress(emailERP.FromAddress, emailERP.FromName);

            foreach (string toAddress in toList)
            {
                if (!string.IsNullOrWhiteSpace(toAddress))
                {
                    mailMessage.To.Add(new MailAddress(toAddress));
                    mailAddressExecutor.To += toAddress + "; ";
                }
            }

            foreach (string ccAddress in ccList)
            {
                if (!string.IsNullOrWhiteSpace(ccAddress))
                {
                    mailMessage.CC.Add(new MailAddress(ccAddress));
                    mailAddressExecutor.CC += ccAddress + "; ";
                }
            }

            var toAddresses = mailAddressExecutor.To;
            var ccAddresses = mailAddressExecutor.CC;

            mailAddressExecutor.To = string.IsNullOrWhiteSpace(toAddresses) ? null : toAddresses.Substring(0, toAddresses.Length - 2);
            mailAddressExecutor.CC = string.IsNullOrWhiteSpace(ccAddresses) ? null : ccAddresses.Substring(0, ccAddresses.Length - 2);

            mailMessage.Subject = emailERP.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            if (emailERP.AlternateView != null)
                mailMessage.AlternateViews.Add(emailERP.AlternateView);
            else
                mailMessage.Body = emailERP.MailBody;

            if (attachment != null && attachment.ContentStream.Length > 0)
                mailMessage.Attachments.Add(attachment);

            mailAddressExecutor.MailMessage = mailMessage;

            return mailAddressExecutor;
        }
    }
}