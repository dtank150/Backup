using Microsoft.EntityFrameworkCore;
using StudentAPIDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIDemo.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAPIContext context;
        public SqlStudentRepository(StudentAPIContext contex)
        {
            this.context = contex;
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x => x.Id == studentId);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<List<Gender>> GetGendersAsync()
        {
            return await context.Gender.ToListAsync();
        }

        public async Task<bool> Exists(Guid studentId)
        {
            return await context.Student.AnyAsync(x => x.Id == studentId);
        }

        public async Task<Student> UpdateStudent(Guid studentId, Student request)
        {
            var exisitingStudent = await GetStudentAsync(studentId);
            if(exisitingStudent != null)
            {
                exisitingStudent.FirstName = request.FirstName;
                exisitingStudent.LastName = request.LastName;
                exisitingStudent.DateOfBirth = request.DateOfBirth;
                exisitingStudent.Email = request.Email;
                exisitingStudent.Mobile = request.Mobile;
                exisitingStudent.GenderId = request.GenderId;
                exisitingStudent.Address.PhysicalAddress = request.Address.PhysicalAddress;
                exisitingStudent.Address.PostalAddress = request.Address.PostalAddress;

                await context.SaveChangesAsync();
                return exisitingStudent;
            }
            return null;
            
        }

        public async Task<Student> DeleteStudent(Guid studentId)
        {
            var student = await GetStudentAsync(studentId);
            if(student != null)
            {
                context.Student.Remove(student);
                await context.SaveChangesAsync();
                return student;
            }
            return null;
        }

        public async Task<Student> AddStudent(Student request)
        {
            var student = await context.Student.AddAsync(request);
            await context.SaveChangesAsync();
            return student.Entity;

        }

        public async Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl)
        {
            var student = await GetStudentAsync(studentId);

            if(student != null)
            {
                student.ProfileImageUrl = profileImageUrl;
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
