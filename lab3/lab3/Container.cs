using System;
using System.Security.Cryptography;
using Ninject.Modules;


	class SimpleConfigModuleMD5 : NinjectModule
	{
		public override void Load()
		{
			Bind<IAlgorithm>().To<HMD5>();
			Bind<Hasher>().ToSelf();
		}
	}

class SimpleConfigModuleSHA256 : NinjectModule
{
	public override void Load()
	{
		Bind<IAlgorithm>().To<HSHA256>();
		Bind<Hasher>().ToSelf();
	}
}