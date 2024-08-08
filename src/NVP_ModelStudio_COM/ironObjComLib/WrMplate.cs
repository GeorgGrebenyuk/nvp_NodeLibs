using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrmplate Interface
///</summary>
namespace ironObjComLib.WrMplate 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMplate_Constructor : INode 
	{
		public ironObjComLib.IWrMplate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrMplate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMplate_ConstructorCast : INode 
	{
		public ironObjComLib.IWrMplate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrMplate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

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
	[NodeInput("WrMplate", typeof(object))]
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
		Text = "property PART_TAG", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_TAG
	///</summary>
	public class Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Tag);

		}
	}


	[NVP_Manifest(
		Text = "property PART_STANDARD", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_STANDARD
	///</summary>
	public class part_standatd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_standatd);

		}
	}


	[NVP_Manifest(
		Text = "property PART_STANDARD", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_STANDARD
	///</summary>
	public class Set_part_standatd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_standatd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL_CLASS", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL_CLASS
	///</summary>
	public class part_material_class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_material_class);

		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL_CLASS", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL_CLASS
	///</summary>
	public class Set_part_material_class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_material_class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL
	///</summary>
	public class Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material);

		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL
	///</summary>
	public class Set_Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL_STANDARD", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL_STANDARD
	///</summary>
	public class Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material_Standard);

		}
	}


	[NVP_Manifest(
		Text = "property PART_MATERIAL_STANDARD", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL_STANDARD
	///</summary>
	public class Set_Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PART_WEIGHT", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_WEIGHT
	///</summary>
	public class Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight);

		}
	}


	[NVP_Manifest(
		Text = "property height", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property height
	///</summary>
	public class part_height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_height);

		}
	}


	[NVP_Manifest(
		Text = "property height", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property height
	///</summary>
	public class Set_part_height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property dimLength", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property dimLength
	///</summary>
	public class dimLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.dimLength);

		}
	}


	[NVP_Manifest(
		Text = "property dimWidth", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property dimWidth
	///</summary>
	public class dimWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.dimWidth);

		}
	}
}
