using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSCOWBlockRef Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsUnitsLib.MDSCOWBlockRef 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCOWBlockRef_Constructor : INode 
	{
		public mdsUnitsLib.IMDSCOWBlockRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSCOWBlockRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCOWBlockRef_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSCOWBlockRef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSCOWBlockRef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property UnitName", 
		ViewType = "Data")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]

	///<summary>
	///property UnitName
	///</summary>
	public class UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitName);

		}
	}


	[NVP_Manifest(
		Text = "property UnitName", 
		ViewType = "Modifier")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property UnitName
	///</summary>
	public class Set_UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]

	///<summary>
	///property Element
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
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
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
		Text = "property UnitPosition", 
		ViewType = "Data")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]

	///<summary>
	///property UnitPosition
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
		Text = "property UnitPosition", 
		ViewType = "Modifier")]
	[NodeInput("MDSCOWBlockRef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property UnitPosition
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
}
