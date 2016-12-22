using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG;

namespace MEGAltSolution
{
    public class ClassRoomRepository
    {

        private List<ClassRoom> _classRooms = new List<ClassRoom>();
        
        public void SaveClassRoom(ClassRoom c) {
            DB.SaveClassRoom(c);
        }

        public bool LoadClassRoomsStudent(string username)
        {
            DB.LoadClassRooms();
        }

        public bool LoadAllStudent(string username)
        {
            DB.Load(string username);
        }
  
        private bool AddClassRoom(ClassRoom c)
        {
            bool canAddClassroom = false;
            if (!_classRooms.Contains(c))
            {
                _classRooms.Add(c);
                canAddClassroom = true;
            }
            return canAddClassroom;
        }
    }
}
