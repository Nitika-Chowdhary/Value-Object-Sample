using BusinessLogicLayer;
using DataTransferObjects;
using System;
using TranslationLayer;

namespace ValueObjectSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicantEducationDTO dto = new ApplicantEducationDTO
            {
                Id = 123,
                DoB = DateTime.Now,
                Name = "Niks",
                Email = "niks@gmail.com"
            };

            CreateApplicantEducation create = new CreateApplicantEducation();
            create.Create(dto);

            GetApplicantEducation get = new GetApplicantEducation();
            ApplicantEducationDTO result = get.Get(56);
        }
    }
}
