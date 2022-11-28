using CustomGenericList.CustomLists.DTOS;
using CustomGenericList.CustomLists.GenericList;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericList.Tests.GenericList
{
    public class GenericList_Student_Should
    {
        [Fact]
        public void GenericList_Should_Return_Length_Of_Elements()
        {
            var chris = new Student { Id = 10, Name = "Chris", };
            var students = new GenericCustomList<Student>
            {
                chris,
                new Student{ Id= 20, Name = "Florin"},
                new Student{ Id= 30, Name = "Gigi" }
            };

            students.Count.ShouldBe(3);
        }


        [Fact]
        public void GenericList_Should_Contain_Added_Element()
        {
            var chris = new Student { Id = 10, Name = "Chris", };
            var students = new GenericCustomList<Student>
            {
                chris,
                new Student{ Id= 20, Name = "Florin"},
                new Student{ Id= 30, Name = "Gigi" }
            };

            students.Contains(chris).ShouldBeTrue();
        }

        [Fact]
        public void GenericList_Remove_Sould_Remove_Item()
        {

            var chris = new Student { Id = 10, Name = "Chris", };
            var students = new GenericCustomList<Student>
            {
                chris,
                new Student{ Id= 20, Name = "Florin"},
                new Student{ Id= 30, Name = "Gigi" }
            };

            students.Remove(chris).ShouldBeTrue();
            students.ShouldNotContain(chris);
        }


        /// <summary>
        /// This test fails for now
        /// </summary>
        [Fact]
        public void GenericList_Sould_Iterate()
        {

            var chris = new Student { Id = 10, Name = "Chris", };
            var students = new GenericCustomList<Student>
            {
                chris,
                new Student{ Id= 20, Name = "Florin"},
                new Student{ Id= 30, Name = "Gigi" }
            };

            var interations = 0;
            foreach (var p in students)
            {
                interations++;
            }

            interations.ShouldBeEquivalentTo(students.Count);
        }


    }
}
