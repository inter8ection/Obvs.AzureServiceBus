﻿using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace Obvs.AzureServiceBus.Infrastructure
{
    internal sealed class MessageSenderWrapper : IMessageSender
    {
        MessageSender _messageSender;

        public MessageSenderWrapper(MessageSender messageSender)
        {
            if(messageSender == null) throw new ArgumentNullException("messageSender");
            
            _messageSender = messageSender;
        }

        public void Send(BrokeredMessage brokeredMessage)
        {
            _messageSender.Send(brokeredMessage);
        }

        public Task SendAsync(BrokeredMessage brokeredMessage)
        {
            return _messageSender.SendAsync(brokeredMessage);
        }
    }

}
