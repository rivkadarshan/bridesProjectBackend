using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using Dto.classes;

namespace Dal.converters
{
    public class CorrectionConvert
    {
        public static CorrectionDto ToDto(Correction c)
        {

            return new CorrectionDto
            {
               CorrectionId=c.CorrectionId,
               CustomerId=c.CustomerId,
               EmployeeIdTakeCorrections=c.EmployeeIdTakeCorrections,
               EmployeeIdDeliverMessage=c.EmployeeIdDeliverMessage,
               ReceivingDate=c.ReceivingDate,
               GoldsmithId=c.GoldsmithId,
               IsDeliveredMessage=c.IsDeliveredMessage,
               ForHoeDeliveredMessage=c.ForHoeDeliveredMessage,
               CorrectionDescription=c.CorrectionDescription,
               IsReady=c.IsReady,
            };
        }
        public static Correction ToDal(CorrectionDto c)
        {
            return new Correction
            {
                CorrectionId = c.CorrectionId,
                CustomerId = c.CustomerId,
                EmployeeIdTakeCorrections = c.EmployeeIdTakeCorrections,
                EmployeeIdDeliverMessage = c.EmployeeIdDeliverMessage,
                ReceivingDate = c.ReceivingDate,
                GoldsmithId = c.GoldsmithId,
                IsDeliveredMessage = c.IsDeliveredMessage,
                ForHoeDeliveredMessage = c.ForHoeDeliveredMessage,
                CorrectionDescription = c.CorrectionDescription,
                IsReady=c.IsReady,
            };
        }

        public static List<Correction> ToLDal(List<CorrectionDto> lc)
        {
            List<Correction> newl = new List<Correction>();
            foreach (var item in lc)
            {
                newl.Add(ToDal(item));
            }
            return newl;
        }
        public static List<CorrectionDto> ToLDto(List<Correction> lc)
        {
            List<CorrectionDto> newl = new List<CorrectionDto>();
            foreach (var item in lc)
            {
                newl.Add(ToDto(item));
            }
            return newl;
        }
    }
}

