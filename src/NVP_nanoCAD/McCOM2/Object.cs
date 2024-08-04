using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing object
///</summary>
namespace McCOM2.Object 
{

	[NVP_Manifest(
		Id = "3E4FC232-17CB-4EB4-9F9B-7C7BC3E38694", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Object_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "_Object_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "E67D0ABD-5468-4B6C-ADE5-0165263B7E08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Object_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "_Object_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "CC2BF5D2-5EFC-4AE6-AF1B-D06D5CA9057D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Properties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Properties", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E19A57FE-DDB7-4878-991A-834D643CA083", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5004A9D9-3036-4FE5-B35D-24045A3478E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F9FF0B38-3B63-4373-8129-167C9792C221", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.ViewScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "ViewScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "17F9700C-574B-4709-8426-2E10292D64C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_ViewScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_ViewScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "40E00706-1D88-4A67-ABC9-30124A4D2B03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.DimScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "DimScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8DA0AD72-EBF4-4B66-8049-920FBC6920C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_DimScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_DimScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1880A3A5-D744-4E4C-A73C-8401E4CD9CAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Native", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Native", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9458DAE2-16F5-40D8-94F8-26927015377D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Bounds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Bounds", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "30CF2846-80FB-4A1F-BCF0-29EF95899052", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.ClassName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "ClassName", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "170E5609-EF18-48FD-9A54-AF264CBD06AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "89B48B11-5B35-4896-A3EF-21CDD342C86A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.NativeId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "NativeId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C6D1F7A8-D0C0-4623-B991-7446C8CC3AA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Place", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Place", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9F377EEF-CA9A-4C03-B8CC-D3DD48037B9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Edit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Edit", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1C8FD8B6-DF4D-444D-87A2-009225BDCECB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Erase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Erase", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EA8609B4-FB6E-45DC-A118-62D62439C972", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Copy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Copy", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D867D014-210E-439D-8BA0-A4119EA320C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Transform", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Transform", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2077506D-5C15-42C6-8BA9-34A329E9F380", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Highlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Highlight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "70B9664F-3985-4942-A5F5-D00B4F3A751A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DE8D1BA2-18C1-4486-8F7E-4C52CFA4715C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2B9AED9C-CE3E-4752-ACF2-B8036E8D8466", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Color", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "40A9BAFD-1A0E-4571-87B0-915A75BE8F2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_Color", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D8C3FA55-FAA0-4337-A513-C1A19D8E4920", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.LineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "LineType", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A2A14C09-3C4D-4655-BE6E-B286A9B61D8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_LineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_LineType", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A337D971-96E5-4238-A674-9AE456D7D82B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.LineTypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "LineTypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6E10CB67-7193-40CB-84EB-D19D60A5652B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_LineTypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_LineTypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6F87979A-57AD-4642-8039-449D806F2F21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.LineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "LineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "05081CA3-D0A9-40D6-99A1-7C063F1BC846", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Object.Set_LineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Object", 
		NodeName = "Set_LineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
