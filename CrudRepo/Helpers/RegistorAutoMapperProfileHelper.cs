using AutoMapper;
using CrudRepo.Profiles;

namespace CrudRepo.Helpers
{
    public class RegistorAutoMapperProfileHelper
    {
        public static IMapper RegistorProfiles(IServiceProvider provider)
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserProfile>();
                cfg.ConstructServicesUsing(type => ActivatorUtilities.CreateInstance(provider, type));
            }).CreateMapper();
        }
    }
}
