using System.Threading.Tasks;

namespace BaseVM.Custom
{
    public abstract  class EditableDataVM<T> : ViewModelBase where T :class
    {
        public EditableDataVM(T innerValue)
        {
            InnerValue = innerValue;
        }

        public T InnerValue { get; private set; }

        public abstract Task SaveChanges();
    }
}
