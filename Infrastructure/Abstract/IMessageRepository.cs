using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstract
{
    public interface IMessageRepository
    {
        Task<HelloWorldMessage> GetMessageObject();
    }
}
