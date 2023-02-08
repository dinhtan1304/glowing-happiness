using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Viet
{
    public interface IManager
    {
        public void InputList();
        public void ShowList();
        void Delete(string? code);
        void Update(string? code);
        void LoadFile();
        void SaveFile();
    }
}
