﻿using DesignPatterns.Pattern.Behavioral.Command;
using DesignPatterns.Pattern.Behavioral.Iterator;
using DesignPatterns.Pattern.Behavioral.Observer.WithSubscriber;
using DesignPatterns.Pattern.Behavioral.State;
using DesignPatterns.Pattern.Behavioral.Strategy;
using DesignPatterns.Pattern.Behavioral.TemplateMethod;
using DesignPatterns.Pattern.Behavioral.Visitor;
using DesignPatterns.Pattern.Creational.AbstractFactory;
using DesignPatterns.Pattern.Creational.Builder;
using DesignPatterns.Pattern.Creational.FactoryMethod;
using DesignPatterns.Pattern.Creational.Singleton;
using DesignPatterns.Pattern.Other.NullObject;
using DesignPatterns.Pattern.Structural.Adapter;
using DesignPatterns.Pattern.Structural.Bridge;
using DesignPatterns.Pattern.Structural.Composite;
using DesignPatterns.Pattern.Structural.Decorator;
using DesignPatterns.Pattern.Structural.Facade;
using DesignPatterns.Pattern.Structural.Proxy;
using DesignPatterns.Utilities;

#pragma warning disable SA1515
#pragma warning disable SA1512
namespace DesignPatterns {
  public static class Program {
    private static readonly ConsoleUtilities ConsoleUtilities = new ConsoleUtilities();

    // TODO: Provide readme file with observations & usage strategies and notes how I understand the patterns
    // TODO: Confront understanding with "Design Patterns: Elements of Reusable Object-Oriented Software" book
    // TODO: Consider UML diagrams
    public static void Main() {
      SoftwareDesignPatterns();
      EnterpriseArchitectureDesignPatterns();

      ConsoleUtilities.PauseApp();
    }

    private static void SoftwareDesignPatterns() {
      CreationalPatterns();
      StructuralPattterns();
      BehavioralPatterns();
      OtherPatterns();
    }

    #region Software Design Patterns
    private static void CreationalPatterns() {
      ConsoleUtilities.DisplayInBlock(new AbstractFactoryPatternSample());
      ConsoleUtilities.DisplayInBlock(new FactoryMethodPatternSample());
      ConsoleUtilities.DisplayInBlock(new SingletonPatternSample());
      ConsoleUtilities.DisplayInBlock(new BuilderPatternSample());
      // TODO: Prototype pattern
    }

    private static void StructuralPattterns() {
      ConsoleUtilities.DisplayInBlock(new AdapterPatternSample());
      ConsoleUtilities.DisplayInBlock(new BridgePatternSample());
      ConsoleUtilities.DisplayInBlock(new CompositePatternSample());
      ConsoleUtilities.DisplayInBlock(new DecoratorPatternSample());
      ConsoleUtilities.DisplayInBlock(new FacadePatternSample());
      ConsoleUtilities.DisplayInBlock(new ProxyPatternSample());
      // TODO: Flyweight pattern
    }

    private static void BehavioralPatterns() {
      ConsoleUtilities.DisplayInBlock(new StrategyPatternSample());
      ConsoleUtilities.DisplayInBlock(new ObserverPatternWithSubscriberSample());
      ConsoleUtilities.DisplayInBlock(new CommandPatternSample());
      ConsoleUtilities.DisplayInBlock(new TemplateMethodPatternSample());
      ConsoleUtilities.DisplayInBlock(new IteratorPatternSample());
      ConsoleUtilities.DisplayInBlock(new StatePatternSample());
      ConsoleUtilities.DisplayInBlock(new VisitorPatternSample());
      // TODO: Chain of responsibility pattern
      // TODO: Interpreter pattern
      // TODO: Mediator pattern
      // TODO: Memento pattern
    }

    private static void OtherPatterns() {
      ConsoleUtilities.DisplayInBlock(new NullObjectPatternSample());
    }
    #endregion

    private static void EnterpriseArchitectureDesignPatterns() {
      DomainLogicPatterns();
      DataSourceArchitecturalPatterns();
      ObjectRelationalBehavioralPatterns();
      ObjectRelationalStructuralPatterns();
      ObjectRelationalMetadataMappingPatterns();
      WebPresentationPatterns();
      DistributionPatterns();
      OfflineConcurrencyPatterns();
      SessionStatePatterns();
      BasePatterns();
    }

    #region Enterprise Architecture Design Patterns
    private static void DomainLogicPatterns() {
      // TODO: Transaction Script pattern
      // TODO: Domain Model pattern
      // TODO: Table Module pattern
      // TODO: Service Layer pattern
    }

    private static void DataSourceArchitecturalPatterns() {
      // TODO: Table Data Gateway pattern
      // TODO: Row Data Gateway pattern
      // TODO: Active Record pattern
      // TODO: Data Mapper pattern
    }

    private static void ObjectRelationalBehavioralPatterns() {
      // TODO: Unit of Work pattern
      // TODO: Identity Map pattern
      // TODO: Lazy Load pattern
    }

    private static void ObjectRelationalStructuralPatterns() {
      // TODO: Identity Field pattern
      // TODO: Foreign Key Mapping pattern
      // TODO: Association Table Mapping pattern
      // TODO: Dependent Mapping pattern
      // TODO: Embedded Value pattern
      // TODO: Serialized LOB pattern
      // TODO: Single Table Inheritance pattern
      // TODO: Class Table Inheritance pattern
      // TODO: Concrete Table Inheritance pattern
      // TODO: Inheritance Mappers pattern
    }

    private static void ObjectRelationalMetadataMappingPatterns() {
      // TODO: Metadata Mapping pattern
      // TODO: Query Object pattern
      // TODO: Repository pattern
    }

    private static void WebPresentationPatterns() {
      // TODO: Model View Controller pattern
      // TODO: Page Controller pattern
      // TODO: Front Controller pattern
      // TODO: Template View pattern
      // TODO: Transform View pattern
      // TODO: Two-Step View pattern
      // TODO: Application Controller pattern
    }

    private static void DistributionPatterns() {
      // TODO: Remote Facade pattern
      // TODO: Data Transfer Object pattern
    }

    private static void OfflineConcurrencyPatterns() {
      // TODO: Optimistic Offline Lock pattern
      // TODO: Pessimistic Offline Lock pattern
      // TODO: Coarse Grained Lock pattern
      // TODO: Implicit Lock pattern
    }

    private static void SessionStatePatterns() {
      // TODO: Client Session State pattern
      // TODO: Server Session State pattern
      // TODO: Database Session State pattern
    }

    private static void BasePatterns() {
      // TODO: Gateway pattern
      // TODO: Mapper pattern
      // TODO: Layer Supertype pattern
      // TODO: Separated Interface pattern
      // TODO: Registry pattern
      // TODO: Value Object pattern
      // TODO: Money pattern
      // TODO: Special Case pattern
      // TODO: Plugin pattern
      // TODO: Service Stub pattern
      // TODO: Record Set pattern
    }
    #endregion
  }
}
