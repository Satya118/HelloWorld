using Domain;
using Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;


namespace Infrastructure.Concrete
{
    public class MessageRepository : IMessageRepository
    {

        public async Task<HelloWorldMessage> GetMessageObject()
        {
            var obj = A.Fake<HelloWorldMessage>();
            await Task.Run(() =>
            {
                obj.Message = "Hello World";
            });
            return obj;
        }
    }
}
