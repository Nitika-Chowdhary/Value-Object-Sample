using DataTransferObjects;
using Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class CreateApplicantEducation
    {
        //database layer only knows about pocos, client side only know about dto, the business logic layer translates between the two types
        public void Create(ApplicantEducationDTO dto)
        {
            //translation
            ApplicantEducationPoco poco = new ApplicantEducationPoco
            {
                Id = dto.Id,
                DoB = dto.DoB,
                Name = dto.Name,
                Email = dto.Email
            };

            //save in a database

        }
    }
}
