using System.Threading.Tasks;

namespace Templar.Aplication.Base
{
    public interface IProcess
    {
        void Execute();
    }

    public interface IProcess<TParam>
        where TParam : class
    {
        void Execute(TParam parameters);
    }

    public interface IProcess<TParameter, TResult>
    {
        TResult Execute(TParameter param);
    }
}
