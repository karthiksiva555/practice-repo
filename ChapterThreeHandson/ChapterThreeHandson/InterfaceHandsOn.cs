using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThreeHandson
{
    public interface IUndoable { void Undo();}

    public class InterfaceHandsOn : IUndoable
    {
        void IUndoable.Undo() => Undo();
        public virtual void Undo() => Console.WriteLine("IntefaceHandsOn.Undo");
    }

    public class DerivedInterfaceClass : InterfaceHandsOn, IUndoable 
    {
        public override void Undo() => Console.WriteLine("DerivedIntefaceClass.Undo");
    }

}
