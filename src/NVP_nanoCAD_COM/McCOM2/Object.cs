using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing object
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.Object 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Object_Constructor : INode 
	{
		public McCOM2.IObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Object_ConstructorCast : INode 
	{
		public McCOM2.IObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000009a", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x0000009a
	///</summary>
	public class Properties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Properties);

		}
	}


	[NVP_Manifest(
		Text = "0x0000009c", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x0000009c
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Text = "0x0000009c", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("vResult", typeof(System.Object))]

	///<summary>
	///0x0000009c
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000009b", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x0000009b
	///</summary>
	public class ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewScale);

		}
	}


	[NVP_Manifest(
		Text = "0x0000009b", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("prViewScale", typeof(System.Double))]

	///<summary>
	///0x0000009b
	///</summary>
	public class Set_ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000092", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000092
	///</summary>
	public class DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimScale);

		}
	}


	[NVP_Manifest(
		Text = "0x00000092", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("prDimScale", typeof(System.Double))]

	///<summary>
	///0x00000092
	///</summary>
	public class Set_DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000098", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000098
	///</summary>
	public class Native : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Native);

		}
	}


	[NVP_Manifest(
		Text = "0x0000008f", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x0000008f
	///</summary>
	public class Bounds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bounds);

		}
	}


	[NVP_Manifest(
		Text = "0x00000090", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000090
	///</summary>
	public class ClassName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClassName);

		}
	}


	[NVP_Manifest(
		Text = "0x00000093", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000093
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Text = "0x00000099", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000099
	///</summary>
	public class NativeId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NativeId);

		}
	}


	[NVP_Manifest(
		Text = "0x0000008d", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("vbDialog", typeof(System.Object))]
	[NodeInput("vbPosition", typeof(System.Object))]
	[NodeInput("vParams", typeof(System.Object))]

	///<summary>
	///0x0000008d
	///</summary>
	public class Place : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Place(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000008a", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("atPoint", typeof(System.Object))]

	///<summary>
	///0x0000008a
	///</summary>
	public class Edit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Edit(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000008b", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x0000008b
	///</summary>
	public class Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Erase();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000089", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000089
	///</summary>
	public class Copy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Copy);

		}
	}


	[NVP_Manifest(
		Text = "0x0000008e", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("vMatrix4x4", typeof(System.Object))]

	///<summary>
	///0x0000008e
	///</summary>
	public class Transform : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Transform(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000008c", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("vbHighlight", typeof(System.Object))]
	[NodeInput("rgbColor", typeof(System.Object))]
	[NodeInput("vbPan", typeof(System.Object))]

	///<summary>
	///0x0000008c
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000094", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000094
	///</summary>
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	[NVP_Manifest(
		Text = "0x00000094", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000094
	///</summary>
	public class Set_Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Layer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000091", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000091
	///</summary>
	public class Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Color);

		}
	}


	[NVP_Manifest(
		Text = "0x00000091", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("prgbValue", typeof(System.Object))]

	///<summary>
	///0x00000091
	///</summary>
	public class Set_Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Color = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000095", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000095
	///</summary>
	public class LineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineType);

		}
	}


	[NVP_Manifest(
		Text = "0x00000095", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("McCOM2.LineType", typeof(System.Object))]

	///<summary>
	///0x00000095
	///</summary>
	public class Set_LineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineType = ((McCOM2.LineType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000096", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000096
	///</summary>
	public class LineTypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScale);

		}
	}


	[NVP_Manifest(
		Text = "0x00000096", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000096
	///</summary>
	public class Set_LineTypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000097", 
		ViewType = "Data")]
	[NodeInput("Object", typeof(object))]

	///<summary>
	///0x00000097
	///</summary>
	public class LineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeight);

		}
	}


	[NVP_Manifest(
		Text = "0x00000097", 
		ViewType = "Modifier")]
	[NodeInput("Object", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000097
	///</summary>
	public class Set_LineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeight = inputs[1].Value;
			return null;
		}
	}
}
