using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSLinkGap Interface
///</summary>
namespace NVP_ModelStudio_COM._SchematiCSCOMLib.MSLinkGap 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkGap_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSLinkGap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSLinkGap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLinkGap_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSLinkGap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSLinkGap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("MSLinkGap", typeof(object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitPosition);

		}
	}


	[NVP_Manifest(
		Text = "Положение объекта", 
		ViewType = "Modifier")]
	[NodeInput("MSLinkGap", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class Set_UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина", 
		ViewType = "Data")]
	[NodeInput("MSLinkGap", typeof(object))]

	///<summary>
	///Длина
	///</summary>
	public class GapLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GapLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина", 
		ViewType = "Modifier")]
	[NodeInput("MSLinkGap", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина
	///</summary>
	public class Set_GapLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GapLength = inputs[1].Value;
			return null;
		}
	}
}
