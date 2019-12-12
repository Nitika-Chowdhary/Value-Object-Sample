using DataTransferObjects;
using Pocos;
using System;

namespace TranslationLayer
{
    public class GetApplicantEducation
    {
        public ApplicantEducationDTO Get(int id)
        {
            //loaded from the database, here doing manually
            ApplicantEducationPoco poco = new ApplicantEducationPoco
            {
                Id = 123,
                DoB = DateTime.Now,
                Name = "Niks",
                Email = "niks@gmail.com"
            };

            ApplicantEducationDTO dto = new ApplicantEducationDTO
            {
                Id = poco.Id,
                DoB = poco.DoB,
                Name = poco.Name,
                Email = poco.Email
            };

            return dto;
        }
    }
}
