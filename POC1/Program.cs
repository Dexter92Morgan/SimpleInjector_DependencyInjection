// See https://aka.ms/new-console-template for more information
using DISimpleInjector.BussinessLayer;
using DISimpleInjector.DataAccessLayer;
using DISimpleInjector.Interface;
using SimpleInjector;

Console.WriteLine("Hello, World!");

var container = new Container();
var lifestyle = Lifestyle.Singleton;

container.Register<ICart, DataAccessLayer>(lifestyle);

container.Options.ResolveUnregisteredConcreteTypes = true; // In case your application depends on Simple Injector’s old behavior where unregistered concrete types could be resolved, and you can’t easily fix this by registering all concrete types, you can switch to the legacy behavior by setting Container.Options.ResolveUnregisteredConcreteTypes = true:
container.Verify();
var BL = container.GetInstance<BussinessLayer>();

BL.InsertCart();

Console.ReadLine();
