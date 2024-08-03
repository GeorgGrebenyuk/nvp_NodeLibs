using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrSegment Interface
///</summary>
namespace vCSViperCSObjComLib.WrSegment 
{

	[NVP_Manifest(
		Id = "CD08AE9E-F57B-466F-9517-5C946E6B5E13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.WrSegment_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "_WrSegment_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrSegment_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "29FE445C-DAF7-477B-81F1-C16B27647278", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.WrSegment_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "_WrSegment_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrSegment_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrSegment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrSegment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A717E4C2-1408-491D-B457-D61A4B050007", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrSegment", typeof(object))]

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
		Id = "0D36BBA1-7E4E-4B93-9677-E80800118146", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrSegment", typeof(object))]
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
		Id = "0E09D6D4-81B9-453A-81F1-CDCCA78EDBDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrSegment", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Id = "315B5DFC-CCD6-420D-9EDD-EB5A5168823F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D8889969-8687-4611-BC3C-97A1F3405199", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.ElementSubSeg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "ElementSubSeg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementSubSeg", 
		ViewType = "Data")]
	[NodeInput("WrSegment", typeof(object))]

	///<summary>
	///property ElementSubSeg
	///</summary>
	public class ElementSubSeg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementSubSeg);

		}
	}


	[NVP_Manifest(
		Id = "41CEDC55-01A2-4CCD-85DA-C70FD88A4000", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.Set_ElementSubSeg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "Set_ElementSubSeg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementSubSeg", 
		ViewType = "Modifier")]
	[NodeInput("WrSegment", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ElementSubSeg
	///</summary>
	public class Set_ElementSubSeg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElementSubSeg = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E0B49E80-91B2-4344-AAB0-0E8C295B24D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.PointStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "PointStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("WrSegment", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class PointStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointStart);

		}
	}


	[NVP_Manifest(
		Id = "AEAED1EB-1332-4DA6-A139-53ED6DBE5D57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrSegment.PointEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrSegment", 
		NodeName = "PointEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("WrSegment", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class PointEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointEnd);

		}
	}
}
