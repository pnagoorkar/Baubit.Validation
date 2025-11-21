using FluentResults;

namespace Baubit.Validation
{
    public interface IValidator<T>
    {
        public Result Run(T validatable);
    }
}
