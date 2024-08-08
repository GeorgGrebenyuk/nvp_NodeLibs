using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSXRef Interface
///</summary>
namespace SchematiCSCOMLib.MSXRef 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSXRef_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSXRef_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSXRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSXRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Назначение", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Назначение
	///</summary>
	public class Destination : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Destination);

		}
	}


	[NVP_Manifest(
		Text = "Назначение", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Назначение
	///</summary>
	public class Set_Destination : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Destination = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Имя текущей ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Имя текущей ссылки
	///</summary>
	public class NameSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameSelf);

		}
	}


	[NVP_Manifest(
		Text = "Имя текущей ссылки", 
		ViewType = "Modifier")]
	[NodeInput("MSXRef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Имя текущей ссылки
	///</summary>
	public class Set_NameSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NameSelf = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Состояние ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Состояние ссылки
	///</summary>
	public class BindState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BindState);

		}
	}


	[NVP_Manifest(
		Text = "Handle текущей ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Handle текущей ссылки
	///</summary>
	public class HandleSelf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleSelf);

		}
	}


	[NVP_Manifest(
		Text = "Handle другой ссылки", 
		ViewType = "Data")]
	[NodeInput("MSXRef", typeof(object))]

	///<summary>
	///Handle другой ссылки
	///</summary>
	public class HandleTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleTo);

		}
	}
}
