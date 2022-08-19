namespace Templar.Aplication.Base
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<TParameter>
    {
        void Execute(TParameter param);
    }

    public interface ICommand<TParameter, TResult>
    {
        TResult Execute(TParameter param);
    }
}
