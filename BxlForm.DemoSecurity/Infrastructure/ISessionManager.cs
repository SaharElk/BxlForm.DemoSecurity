using BxlForm.DemoSecurity.Models.Client.Data;

namespace BxlForm.DemoSecurity.Infrastructure
{
    public interface ISessionManager
    {
        UserSession User { get; set; }

        void Clear();
    }
}