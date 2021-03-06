﻿using Castle.Facilities.FactorySupport;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using GradeGrinder.Persistence;
using GradeGrinder.Persistence.Dao;
using GradeGrinder.Persistence.Hibernate;
using GradeGrinder.Persistence.Hibernate.Dao;
using NHibernate;
using NHibernate.Engine;
using uNhAddIns.CastleAdapters;
using uNhAddIns.CastleAdapters.AutomaticConversationManagement;
using uNhAddIns.SessionEasier;
using uNhAddIns.SessionEasier.Conversations;

namespace GradeGrinder.IoC.Windsor
{
    public class ContainerProvider
    {
        private static IWindsorContainer _container;

        public static IWindsorContainer Container { get { return _container; } }

        static ContainerProvider()
        {
            Init();
            RegisterDaos();
        }

        private static void Init()
        {
            _container = new WindsorContainer();
            _container.AddFacility<PersistenceConversationFacility>();
            _container.AddFacility<FactorySupportFacility>();

            _container.Register(Component.For<ISessionFactoryProvider>().ImplementedBy<SessionFactoryProvider>());

            _container.Register(Component.For<ISessionFactory>().UsingFactoryMethod(
                    () => _container.Resolve<ISessionFactoryProvider>().GetFactory(null)));

            _container.Register(Component.For<ISessionFactoryImplementor>().UsingFactoryMethod(
                    () => (ISessionFactoryImplementor) _container.Resolve<ISessionFactoryProvider>().GetFactory(null)));

            _container.Register(Component.For<ISessionWrapper>().ImplementedBy<SessionWrapper>());

            _container.Register(Component.For<IConversationFactory>().ImplementedBy<DefaultConversationFactory>());

            _container.Register(Component.For<IConversationsContainerAccessor>().ImplementedBy<NhConversationsContainerAccessor>());

            _container.Register(Component.For(typeof(IDao<>)).ImplementedBy(typeof(Dao<>)));
        }

        private static void RegisterDaos()
        {
            _container.Register(Component.For<IEditStudentModel>().ImplementedBy<EditStudentModel>().LifeStyle.Transient);
        }
    }
}
