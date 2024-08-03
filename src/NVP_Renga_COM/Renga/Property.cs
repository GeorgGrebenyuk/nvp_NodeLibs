using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Property 
{

	[NVP_Manifest(
		Id = "2A5D2937-82B2-417C-8AB9-794D591AF4EC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.Property_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "_Property_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_Constructor : INode 
	{
		public Renga.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8638242D-7F9C-4791-9176-92A1AC012D28", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.Property_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "_Property_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_ConstructorCast : INode 
	{
		public Renga.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9CE9EB25-3A28-48DB-BD29-9AC74213B4F1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetDoubleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetDoubleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoubleValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9086D1C6-C58B-483D-B0B4-4A6D17ED6E69", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetStringValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetStringValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetStringValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4631C06-9359-439B-94C8-8F9623B382F2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetDoubleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetDoubleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoubleValue);

		}
	}


	[NVP_Manifest(
		Id = "5952FBDF-16F5-4CCE-8876-9F14465D425A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetStringValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetStringValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStringValue);

		}
	}


	[NVP_Manifest(
		Id = "28CEADA0-2FED-47D2-B070-F444A6F14E93", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "AAAED43E-099C-4AF5-9221-48E7D6167C84", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.ResetValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "ResetValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetValue();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA2E3D11-E1EE-42F1-A79D-0E82A9366434", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.HasValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "HasValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}


	[NVP_Manifest(
		Id = "B310F72B-1404-4F5E-9287-9DEAEB2C943D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
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
		Id = "09E36C19-31DB-45F8-8B57-74B5DF5CC717", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		Id = "31FE8962-7C9C-490E-8482-80AA77ACDBE8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
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
		Id = "5935D1E8-E5D9-46EF-8FAB-BF8CADD7002C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetAngleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetAngleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.AngleUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAngleValue(inputs[1].Value,((Renga.AngleUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74E934D2-D8AF-486D-BAFF-94C853317D23", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetAreaValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetAreaValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetAreaValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAreaValue(inputs[1].Value,((Renga.AreaUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F2E8A32D-191A-4590-89F7-FA7C633DB83F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetBooleanValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetBooleanValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetBooleanValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBooleanValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AA705809-DEBC-4088-9A46-5CCF8CDF313B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetEnumerationValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetEnumerationValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetEnumerationValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetEnumerationValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D5053A7-789F-486D-8047-11A1CA44636B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetIntegerValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetIntegerValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetIntegerValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetIntegerValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25284993-9775-45F6-BB15-BEDD476FFA30", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetLengthValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetLengthValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetLengthValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLengthValue(inputs[1].Value,((Renga.LengthUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "71D50443-3EC4-45A8-9D3F-C54FCAA3445F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetLogicalValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetLogicalValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.Logical", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetLogicalValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLogicalValue(((Renga.Logical)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EBEEE124-AD29-4326-A229-7917F3916FBE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetMassValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetMassValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetMassValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetMassValue(inputs[1].Value,((Renga.MassUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "07ED5DAF-DEE6-4187-B9D6-3FF25208DE45", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.SetVolumeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "SetVolumeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetVolumeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetVolumeValue(inputs[1].Value,((Renga.VolumeUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AB470B00-B5A1-4A2D-B504-6FB382991247", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetAngleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetAngleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.AngleUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleValue(((Renga.AngleUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "4BAE8FBE-7F89-45D9-B147-DB75D22D2F8F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetAreaValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetAreaValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetAreaValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAreaValue(((Renga.AreaUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "A997A8EB-14F0-4C69-A354-67E0A511C7FB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetBooleanValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetBooleanValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBooleanValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBooleanValue);

		}
	}


	[NVP_Manifest(
		Id = "32B8BA09-B3E6-4D53-848A-708CD95238A0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetEnumerationValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetEnumerationValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEnumerationValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEnumerationValue);

		}
	}


	[NVP_Manifest(
		Id = "35B9ACCC-4536-4F88-B2F8-8D76A7C64F18", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetIntegerValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetIntegerValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIntegerValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIntegerValue);

		}
	}


	[NVP_Manifest(
		Id = "F5154767-0B59-4539-991B-EC8D29C269BA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetLengthValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetLengthValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetLengthValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthValue(((Renga.LengthUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "712E34F9-E8DE-4682-B39B-BB96580618B2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetLogicalValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetLogicalValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLogicalValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLogicalValue);

		}
	}


	[NVP_Manifest(
		Id = "F499D6FC-8082-436D-BAFB-9C04B4CCF841", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetMassValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetMassValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetMassValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMassValue(((Renga.MassUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "F8EC4180-17B5-4B53-9A3E-64EFB6923F2C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Property.GetVolumeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Property", 
		NodeName = "GetVolumeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetVolumeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolumeValue(((Renga.VolumeUnit)inputs[1].Value)));

		}
	}
}
