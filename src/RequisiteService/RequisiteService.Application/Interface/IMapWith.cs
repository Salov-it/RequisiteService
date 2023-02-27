using AutoMapper;

namespace RequisiteService.Application.Interface
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());

    }
}
