// See https://aka.ms/new-console-template for more information
using Abstractions;
using ConcreteImplementations;
using RefinedAbstractions;

PlusRemote remote=new PlusRemote(new Radio());
for(var i=0;i<5;i++)
    remote.ChannelUp();

remote.ChannelDown();

remote.Mute();