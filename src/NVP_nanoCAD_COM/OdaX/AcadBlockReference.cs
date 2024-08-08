using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an instance of a block definition inserted into a drawing
///</summary>
namespace OdaX.AcadBlockReference 
{

	[NVP_Manifest(
		Id = "07F3C568-906C-4B31-A50A-854657D94328", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.AcadBlockReference_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "_AcadBlockReference_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlockReference_Constructor : INode 
	{
		public OdaX.IAcadBlockReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlockReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DAC3C8D4-21E1-422D-8E1C-5B20F26B2A77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.AcadBlockReference_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "_AcadBlockReference_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlockReference_ConstructorCast : INode 
	{
		public OdaX.IAcadBlockReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlockReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C090DC21-EEF1-41A1-B2C3-86FFF3EFC3F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Id = "AFA93094-295F-4394-A0A7-E3BD3D33077C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F112AB62-1B2E-447F-8524-E3641382D29D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the name of a block or external reference.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "ABB79D88-4AF3-47B7-B86B-F54F5399DD67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a block or external reference.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "62C371B5-3F9D-4921-8945-55A9C275FA96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Id = "4DABCBC2-ACA1-4C63-A94C-9FA5A82A7E0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1828B7BE-1957-411F-826D-43C4B900D8FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a block or external reference.
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Id = "8B8EF98C-A26C-4315-99A1-6883FC38EF30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of a block or external reference.
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "638CC9B5-DFC4-480F-8331-E85FE2E631E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.XScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "XScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the XScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the XScale factor of a block or external reference.
	///</summary>
	public class XScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "48B4C5C7-C013-44E9-9EC7-297052D5CBCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_XScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_XScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the XScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the XScale factor of a block or external reference.
	///</summary>
	public class Set_XScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E47C9D46-9A55-464A-A154-8221499A68AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.YScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "YScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the YScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the YScale factor of a block or external reference.
	///</summary>
	public class YScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "6FDFFE58-6519-4921-B3C5-2133E8296090", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_YScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_YScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the YScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the YScale factor of a block or external reference.
	///</summary>
	public class Set_YScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4828947E-AA35-4D51-A9C9-591E54D8A0EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.ZScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "ZScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ZScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the ZScale factor of a block or external reference.
	///</summary>
	public class ZScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "4FDAD6C1-385E-4DB8-8608-0A9620713E4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_ZScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_ZScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ZScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the ZScale factor of a block or external reference.
	///</summary>
	public class Set_ZScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C2FB3F7D-B7D5-4464-BE14-633627AD0A41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes the block or external reference and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Explodes the block or external reference and returns the individual entities as an array of the object.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	[NVP_Manifest(
		Id = "E8824DE1-4642-412D-AF7D-F6831CF904A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.GetAttributes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "GetAttributes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the attributes of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the attributes of a block or external reference.
	///</summary>
	public class GetAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAttributes);

		}
	}


	[NVP_Manifest(
		Id = "54A4C23B-C615-43F9-86BF-08D95B6EB457", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.GetConstantAttributes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "GetConstantAttributes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the constant attributes of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the constant attributes of a block or external reference.
	///</summary>
	public class GetConstantAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetConstantAttributes);

		}
	}


	[NVP_Manifest(
		Id = "F88F4973-8810-470C-836A-AA33A18CB108", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.HasAttributes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "HasAttributes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns if a block or external reference has any attributes associated with it.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns if a block or external reference has any attributes associated with it.
	///</summary>
	public class HasAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasAttributes);

		}
	}


	[NVP_Manifest(
		Id = "5D3E9713-ACE5-46DB-B91E-AE501EAA1C2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.EffectiveName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "EffectiveName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the original name of a block reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the original name of a block reference.
	///</summary>
	public class EffectiveName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EffectiveName);

		}
	}


	[NVP_Manifest(
		Id = "29CB8E59-6A93-4D43-806B-E4557EAD4C02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.IsDynamicBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "IsDynamicBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns if a block reference is dynamic.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns if a block reference is dynamic.
	///</summary>
	public class IsDynamicBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDynamicBlock);

		}
	}


	[NVP_Manifest(
		Id = "191ADF0B-BB24-4FB1-8781-20DD22EC2B1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.GetDynamicBlockProperties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "GetDynamicBlockProperties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the properties of a dynamic block reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the properties of a dynamic block reference.
	///</summary>
	public class GetDynamicBlockProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDynamicBlockProperties);

		}
	}


	[NVP_Manifest(
		Id = "0E80B7C8-1E06-4395-98A6-0EDE3ADDD6AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.ResetBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "ResetBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Changes a dynamic block reference to its original state.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Changes a dynamic block reference to its original state.
	///</summary>
	public class ResetBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetBlock();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4267A379-A336-44E4-A9E5-CC96FFA24FC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.ConvertToAnonymousBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "ConvertToAnonymousBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Converts a dynamic block reference to a regular block reference with no name.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Converts a dynamic block reference to a regular block reference with no name.
	///</summary>
	public class ConvertToAnonymousBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConvertToAnonymousBlock();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6C0CB19C-434A-4CF1-B28D-FD3EDFA14622", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.ConvertToStaticBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "ConvertToStaticBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Converts a dynamic block reference to a regular block reference with a name.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("newBlockName", typeof(System.String))]

	///<summary>
	///Converts a dynamic block reference to a regular block reference with a name.
	///</summary>
	public class ConvertToStaticBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConvertToStaticBlock(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B8A0BE63-7B56-4295-A537-8558ECBB69E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.XEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "XEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective XScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective XScale factor of a block or external reference.
	///</summary>
	public class XEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "416B4125-0CA7-4D33-B92D-BAA7F1AC3FF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_XEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_XEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective XScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective XScale factor of a block or external reference.
	///</summary>
	public class Set_XEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9134EAE3-80AF-4607-ABAE-257E89D04F85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.YEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "YEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective YScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective YScale factor of a block or external reference.
	///</summary>
	public class YEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "75C529BF-C74E-4F5E-918F-95FC9153F3B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_YEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_YEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective YScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective YScale factor of a block or external reference.
	///</summary>
	public class Set_YEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "664E7CA4-2692-42B9-9948-8F7BF94C20C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.ZEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "ZEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective ZScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective ZScale factor of a block or external reference.
	///</summary>
	public class ZEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "F13549D0-5935-44B2-89E9-5C7AB4E435DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.Set_ZEffectiveScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "Set_ZEffectiveScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the effective ZScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective ZScale factor of a block or external reference.
	///</summary>
	public class Set_ZEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83EF0C41-5292-4C18-B7B4-CC852A10B484", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.InsUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "InsUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the insertion units of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the insertion units of a block or external reference.
	///</summary>
	public class InsUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsUnits);

		}
	}


	[NVP_Manifest(
		Id = "44A2F343-BA42-4D10-8F0F-C9C5120AA73D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlockReference.InsUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlockReference", 
		NodeName = "InsUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the insertion units factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the insertion units factor of a block or external reference.
	///</summary>
	public class InsUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsUnitsFactor);

		}
	}
}
