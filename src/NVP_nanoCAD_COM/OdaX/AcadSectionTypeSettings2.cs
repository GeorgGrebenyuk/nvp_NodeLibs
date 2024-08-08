using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IAcadSectionTypeSettings2 Interface
///</summary>
namespace OdaX.AcadSectionTypeSettings2 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings2_Constructor : INode 
	{
		public OdaX.IAcadSectionTypeSettings2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionTypeSettings2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings2_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionTypeSettings2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionTypeSettings2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the visibility of intersection boundary", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings2", typeof(object))]

	///<summary>
	///Specifies the visibility of intersection boundary
	///</summary>
	public class IntersectionBoundaryVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryVisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the visibility of intersection boundary", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings2", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of intersection boundary
	///</summary>
	public class Set_IntersectionBoundaryVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryVisible = inputs[1].Value;
			return null;
		}
	}
}
