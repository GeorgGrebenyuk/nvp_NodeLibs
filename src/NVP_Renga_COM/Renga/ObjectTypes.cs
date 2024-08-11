using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace Renga.ObjectTypes
{
    public class RengaObjectTypes
    {
        public static Guid AngularDimension = new Guid("{96788994-b7fc-41d7-8a99-d674543e9237}");
        public static Guid AssemblyInstance = new Guid("{00799249-1824-4ebd-bf93-40bb92efa9e6}");
        public static Guid Axis = new Guid("{4b41ccf8-c969-4c55-a1f2-cced9c164f07}");
        public static Guid Beam = new Guid("{63478188-7c88-4a6d-b891-9725f04a5bc7}");
        public static Guid Column = new Guid("{d9ee2442-e807-42fb-8fe5-9dcfe543035d}");
        public static Guid DiametralDimension = new Guid("{2aabe3a4-a29e-4534-a9f5-0f070fee240c}");
        public static Guid Door = new Guid("{1cfba99c-01e7-4078-ae1a-3e2ff0673599}");
        public static Guid Duct = new Guid("{06cc88ee-9a67-4626-9c34-dde03c331a74}");
        public static Guid DuctAccessory = new Guid("{47d0d93f-3c7b-4269-bf8a-de246e1724d0}");
        public static Guid DuctFitting = new Guid("{77ffca60-b20e-49f0-b42f-4fdc9b1c825b}");
        public static Guid ElectricDistributionBoard = new Guid("{96da9155-43c1-42b8-bba2-b4f61fa43acc}");
        public static Guid Element = new Guid("{e1e3bd66-2e13-4fa4-a9eb-677e03067c2f}");
        public static Guid Elevation = new Guid("{8a49a9a8-a401-4ab1-8038-92093503c97a}");
        public static Guid Equipment = new Guid("{5d2f3734-5a49-4504-90b1-0676f0f25da7}");
        public static Guid Floor = new Guid("{f5bd8bd8-39c1-47f8-8499-f673c580dfbe}");
        public static Guid Hatch = new Guid("{84b43087-d4a4-4cce-b34d-40e283d9e691}");
        public static Guid Hole = new Guid("{0xecef8f90, 0xcf9, 0x4494, {0x98, 0xde, 0x91, 0x24, 0x2a, 0x2a, 0x9f, 0x5c}}");
        public static Guid IfcObject = new Guid("{f914251d-d5fa-48b2-b93b-074f442cbf3b}");
        public static Guid IsolatedFoundation = new Guid("{6063816c-89ff-4c8f-a814-3be6cb94128e}");
        public static Guid Level = new Guid("{c3ce17ff-6f28-411f-b18d-74fe957b2ba8}");
        public static Guid LightingFixture = new Guid("{793d3f7c-905d-4d85-a351-b152241dd2e7}");
        public static Guid Line3D = new Guid("{02bbebe8-e28b-4ee5-8916-11b514a35dca}");
        public static Guid LinearDimension = new Guid("{dc82ca1a-a0c3-4a1a-aefb-a7d720dd3a09}");
        public static Guid LineElectricalCircuit = new Guid("{83de45e6-4793-49ec-8b9e-65a2438f36de}");
        public static Guid MechanicalEquipment = new Guid("{de4420ce-02b6-4b12-9cd7-9322118be8fe}");
        public static Guid Opening = new Guid("{fc443d5a-b76c-45e5-b91c-520ef0896109}");
        public static Guid Pipe = new Guid("{838cc9f6-e3d8-4132-af6f-c58df0f8d037}");
        public static Guid PipeAccessory = new Guid("{41e2788a-49ed-487f-9ae1-55b6e09ae6e5}");
        public static Guid PipeFitting = new Guid("{d31dc2e3-808e-4987-8481-7f86665a07fc}");
        public static Guid Plate = new Guid("{62cf086e-5a39-4484-840c-ffa6a1c6e2b7}");
        public static Guid PlumbingFixture = new Guid("{b8c7155a-b462-4ff5-bc41-c9c17a9f48fa}");
        public static Guid RadialDimension = new Guid("{377c2fda-9411-43ac-a6c6-0e3b520be721}");
        public static Guid Railing = new Guid("{a1aca786-78a4-4015-b412-9150baad71a9}");
        public static Guid Ramp = new Guid("{debde004-afcc-4da8-8dd0-4223ff836acd}");
        public static Guid Rebar = new Guid("{9fabc932-590f-4068-89a8-ee6ee3d7cbbf}");
        public static Guid Roof = new Guid("{bac4470f-d560-4f57-a49e-faa5f6e5a279}");
        public static Guid Room = new Guid("{f1a805ff-573d-f46b-ffba-57f4bccaa6ed}");
        public static Guid Route = new Guid("{8b323bee-3882-4744-8838-24f45df714a9}");
        public static Guid RoutePoint = new Guid("{ce93e320-7167-4cd1-92a8-5e42d546066b}");
        public static Guid Section = new Guid("{4166fd59-64c0-45ee-ae3b-49fae1257ef1}");
        public static Guid Stair = new Guid("{3f522f49-aee2-4d73-9866-9b07cf336a69}");
        public static Guid TextObject = new Guid("{da557027-f243-4331-bb5b-853abc437cd7}");
        public static Guid Undefined = new Guid("{97675473-ca62-4ea4-bc6e-bb2ca57b7e67}");
        public static Guid Wall = new Guid("{4329112a-6b65-48d9-9da8-abf1f8f36327}");
        public static Guid WallFoundation = new Guid("{d7dd0293-dd65-4229-a64c-8b528d4e226f}");
        public static Guid Window = new Guid("{2b02b353-2ca5-4566-88bb-917ea8460174}");
        public static Guid WiringAccessory = new Guid("{b00d5c25-92a8-4409-a3b7-7c37ed792c06}");
    }

    [NVP_Manifest(
        Text = "Angular dimension object type.",
        ViewType = "Default")]
    public class RengaObjectType_AngularDimension : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.AngularDimension);
        }
    }

    [NVP_Manifest(
        Text = "Assembly object type.",
        ViewType = "Default")]
    public class RengaObjectType_AssemblyInstance : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.AssemblyInstance);
        }
    }

    [NVP_Manifest(
        Text = "Axis object type",
        ViewType = "Default")]
    public class RengaObjectType_Axis : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Axis);
        }
    }

    [NVP_Manifest(
        Text = "Beam object type.",
        ViewType = "Default")]
    public class RengaObjectType_Beam : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Beam);
        }
    }

    [NVP_Manifest(
        Text = "Column object type.",
        ViewType = "Default")]
    public class RengaObjectType_Column : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Column);
        }
    }

    [NVP_Manifest(
        Text = "Diametral dimension object type",
        ViewType = "Default")]
    public class RengaObjectType_DiametralDimension : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.DiametralDimension);
        }
    }

    [NVP_Manifest(
        Text = "Door object type.",
        ViewType = "Default")]
    public class RengaObjectType_Door : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Door);
        }
    }

    [NVP_Manifest(
        Text = "Duct  object type.",
        ViewType = "Default")]
    public class RengaObjectType_Duct : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Duct);
        }
    }

    [NVP_Manifest(
        Text = "DuctAccessory  object type.",
        ViewType = "Default")]
    public class RengaObjectType_DuctAccessory : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.DuctAccessory);
        }
    }

    [NVP_Manifest(
        Text = "DuctFitting object type.",
        ViewType = "Default")]
    public class RengaObjectType_DuctFitting : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.DuctFitting);
        }
    }

    [NVP_Manifest(
        Text = "ElectricDistributionBoard object type.",
        ViewType = "Default")]
    public class RengaObjectType_ElectricDistributionBoard : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.ElectricDistributionBoard);
        }
    }

    [NVP_Manifest(
        Text = "Element object type.",
        ViewType = "Default")]
    public class RengaObjectType_Element : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Element);
        }
    }

    [NVP_Manifest(
        Text = "Elevation object type.",
        ViewType = "Default")]
    public class RengaObjectType_Elevation : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Elevation);
        }
    }

    [NVP_Manifest(
        Text = "Equipment object type.",
        ViewType = "Default")]
    public class RengaObjectType_Equipment : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Equipment);
        }
    }

    [NVP_Manifest(
        Text = "Floor object type.",
        ViewType = "Default")]
    public class RengaObjectType_Floor : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Floor);
        }
    }

    [NVP_Manifest(
        Text = "Hatch object type.",
        ViewType = "Default")]
    public class RengaObjectType_Hatch : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Hatch);
        }
    }

    [NVP_Manifest(
        Text = "Hole object type.",
        ViewType = "Default")]
    public class RengaObjectType_Hole : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Hole);
        }
    }

    [NVP_Manifest(
        Text = "IfcObject object type.",
        ViewType = "Default")]
    public class RengaObjectType_IfcObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.IfcObject);
        }
    }

    [NVP_Manifest(
        Text = "Isolated Foundation object type.",
        ViewType = "Default")]
    public class RengaObjectType_IsolatedFoundation : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.IsolatedFoundation);
        }
    }

    [NVP_Manifest(
        Text = "Level object type.",
        ViewType = "Default")]
    public class RengaObjectType_Level : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Level);
        }
    }

    [NVP_Manifest(
        Text = "LightingFixture object type.",
        ViewType = "Default")]
    public class RengaObjectType_LightingFixture : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.LightingFixture);
        }
    }

    [NVP_Manifest(
        Text = "Line3D object type.",
        ViewType = "Default")]
    public class RengaObjectType_Line3D : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Line3D);
        }
    }

    [NVP_Manifest(
        Text = "LinearDimension object type.",
        ViewType = "Default")]
    public class RengaObjectType_LinearDimension : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.LinearDimension);
        }
    }

    [NVP_Manifest(
        Text = "LineElectricalCircuit object type.",
        ViewType = "Default")]
    public class RengaObjectType_LineElectricalCircuit : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.LineElectricalCircuit);
        }
    }

    [NVP_Manifest(
        Text = "MechanicalEquipment object type.",
        ViewType = "Default")]
    public class RengaObjectType_MechanicalEquipment : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.MechanicalEquipment);
        }
    }

    [NVP_Manifest(
        Text = "Opening object type.",
        ViewType = "Default")]
    public class RengaObjectType_Opening : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Opening);
        }
    }

    [NVP_Manifest(
        Text = "Pipe object type.",
        ViewType = "Default")]
    public class RengaObjectType_Pipe : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Pipe);
        }
    }

    [NVP_Manifest(
        Text = "PipeAccessory object type.",
        ViewType = "Default")]
    public class RengaObjectType_PipeAccessory : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.PipeAccessory);
        }
    }

    [NVP_Manifest(
        Text = "PipeFitting object type.",
        ViewType = "Default")]
    public class RengaObjectType_PipeFitting : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.PipeFitting);
        }
    }

    [NVP_Manifest(
        Text = "Plate object type.",
        ViewType = "Default")]
    public class RengaObjectType_Plate : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Plate);
        }
    }

    [NVP_Manifest(
        Text = "PlumbingFixture object type.",
        ViewType = "Default")]
    public class RengaObjectType_PlumbingFixture : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.PlumbingFixture);
        }
    }

    [NVP_Manifest(
        Text = "RadialDimension object type.",
        ViewType = "Default")]
    public class RengaObjectType_RadialDimension : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.RadialDimension);
        }
    }

    [NVP_Manifest(
        Text = "Railing object type.",
        ViewType = "Default")]
    public class RengaObjectType_Railing : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Railing);
        }
    }

    [NVP_Manifest(
        Text = "Ramp object type.",
        ViewType = "Default")]
    public class RengaObjectType_Ramp : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Ramp);
        }
    }

    [NVP_Manifest(
        Text = "Rebar object type.",
        ViewType = "Default")]
    public class RengaObjectType_Rebar : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Rebar);
        }
    }

    [NVP_Manifest(
        Text = "Roof object type.",
        ViewType = "Default")]
    public class RengaObjectType_Roof : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Roof);
        }
    }

    [NVP_Manifest(
        Text = "Room object type.",
        ViewType = "Default")]
    public class RengaObjectType_Room : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Room);
        }
    }

    [NVP_Manifest(
        Text = "Route object type.",
        ViewType = "Default")]
    public class RengaObjectType_Route : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Route);
        }
    }

    [NVP_Manifest(
        Text = "RoutePoint object type.",
        ViewType = "Default")]
    public class RengaObjectType_RoutePoint : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.RoutePoint);
        }
    }

    [NVP_Manifest(
        Text = "Section object type.",
        ViewType = "Default")]
    public class RengaObjectType_Section : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Section);
        }
    }

    [NVP_Manifest(
        Text = "Stair object type.",
        ViewType = "Default")]
    public class RengaObjectType_Stair : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Stair);
        }
    }

    [NVP_Manifest(
        Text = "TextObject object type.",
        ViewType = "Default")]
    public class RengaObjectType_TextObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.TextObject);
        }
    }

    [NVP_Manifest(
        Text = "Undefined object type.",
        ViewType = "Default")]
    public class RengaObjectType_Undefined : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Undefined);
        }
    }

    [NVP_Manifest(
        Text = "Wall object type.",
        ViewType = "Default")]
    public class RengaObjectType_Wall : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Wall);
        }
    }

    [NVP_Manifest(
        Text = "WallFoundation object type.",
        ViewType = "Default")]
    public class RengaObjectType_WallFoundation : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.WallFoundation);
        }
    }

    [NVP_Manifest(
        Text = "Window object type.",
        ViewType = "Default")]
    public class RengaObjectType_Window : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.Window);
        }
    }

    [NVP_Manifest(
        Text = "WiringAccessory object type.",
        ViewType = "Default")]
    public class RengaObjectType_WiringAccessory : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(RengaObjectTypes.WiringAccessory);
        }
    }

}
