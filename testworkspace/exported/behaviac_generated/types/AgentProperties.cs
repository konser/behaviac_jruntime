﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{
	public class CompareValue_org_gof_worldsrv_EnumTest : ICompareValue<org.gof.worldsrv.EnumTest>
	{
		public override bool Equal(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(org.gof.worldsrv.EnumTest lhs, org.gof.worldsrv.EnumTest rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_org_gof_worldsrv_StructTest : ICompareValue<org.gof.worldsrv.StructTest>
	{
		public override bool Equal(org.gof.worldsrv.StructTest lhs, org.gof.worldsrv.StructTest rhs)
		{
			return (lhs.sv1 == rhs.sv1) && (lhs.sv2 == rhs.sv2);
		}
		public override bool NotEqual(org.gof.worldsrv.StructTest lhs, org.gof.worldsrv.StructTest rhs)
		{
			return !Equal(lhs, rhs);
		}
	}

	public class CompareValue_org_gof_worldsrv_Haha : ICompareValue<org.gof.worldsrv.Haha>
	{
		public override bool Equal(org.gof.worldsrv.Haha lhs, org.gof.worldsrv.Haha rhs)
		{
			return (lhs.sv1 == rhs.sv1) && (lhs.sv2 == rhs.sv2);
		}
		public override bool NotEqual(org.gof.worldsrv.Haha lhs, org.gof.worldsrv.Haha rhs)
		{
			return !Equal(lhs, rhs);
		}
	}


	public class BehaviorLoaderImplement : BehaviorLoader
	{
		class CInstanceConst_org_gof_worldsrv_StructTest : CInstanceConst<org.gof.worldsrv.StructTest>
		{
			IInstanceMember _sv1;
			IInstanceMember _sv2;

			public CInstanceConst_org_gof_worldsrv_StructTest(string typeName, string valueStr) : base(typeName, valueStr)
			{
				List<string> paramStrs = behaviac.StringUtils.SplitTokensForStruct(valueStr);
				Debug.Check(paramStrs != null && paramStrs.Count == 2);

				_sv1 = (CInstanceMember<int>)AgentMeta.ParseProperty<int>(paramStrs[0]);
				_sv2 = (CInstanceMember<double>)AgentMeta.ParseProperty<double>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_sv1 != null);
				Debug.Check(_sv2 != null);

				_value.sv1 = ((CInstanceMember<int>)_sv1).GetValue(self);
				_value.sv2 = ((CInstanceMember<double>)_sv2).GetValue(self);
			}
		};

		class CInstanceConst_org_gof_worldsrv_Haha : CInstanceConst<org.gof.worldsrv.Haha>
		{
			IInstanceMember _sv1;
			IInstanceMember _sv2;

			public CInstanceConst_org_gof_worldsrv_Haha(string typeName, string valueStr) : base(typeName, valueStr)
			{
				List<string> paramStrs = behaviac.StringUtils.SplitTokensForStruct(valueStr);
				Debug.Check(paramStrs != null && paramStrs.Count == 2);

				_sv1 = (CInstanceMember<int>)AgentMeta.ParseProperty<int>(paramStrs[0]);
				_sv2 = (CInstanceMember<double>)AgentMeta.ParseProperty<double>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_sv1 != null);
				Debug.Check(_sv2 != null);

				_value.sv1 = ((CInstanceMember<int>)_sv1).GetValue(self);
				_value.sv2 = ((CInstanceMember<double>)_sv2).GetValue(self);
			}
		};

		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_testbehaviac_x1_MyAgent2_methodHaha : CAgentMethodBase<org.gof.worldsrv.Haha>
		{
			CInstanceMember<org.gof.worldsrv.StructTest> _t1;

			public CMethod_testbehaviac_x1_MyAgent2_methodHaha()
			{
			}

			public CMethod_testbehaviac_x1_MyAgent2_methodHaha(CMethod_testbehaviac_x1_MyAgent2_methodHaha rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_testbehaviac_x1_MyAgent2_methodHaha(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				if (paramStrs[0].StartsWith("{"))
				{
					_t1 = new CInstanceConst_org_gof_worldsrv_StructTest("org.gof.worldsrv.StructTest", paramStrs[0]);
				}
				else
				{
					_t1 = (CInstanceMember<org.gof.worldsrv.StructTest>)AgentMeta.ParseProperty<org.gof.worldsrv.StructTest>(paramStrs[0]);
				}
			}

			public override void Run(Agent self)
			{
				Debug.Check(_t1 != null);

				_t1.Run(self);
				Agent agent = Utils.GetParentAgent(self, _instance);

				_returnValue.value = ((testbehaviac.x1.MyAgent2)agent).methodHaha(((CInstanceMember<org.gof.worldsrv.StructTest>)_t1).GetValue(self));
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 1103027383;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(1044849142);
			AgentMeta._AgentMetas_[1916771456] = meta;
			meta.RegisterMethod(1396400587, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(197161586, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(1810246298, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(2025304058, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(348439993, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(2042517019, new CMethod_behaviac_Agent_VectorRemove());

			// org.gof.worldsrv.MyAgent
			meta = new AgentMeta(833939648);
			AgentMeta._AgentMetas_[646043850] = meta;
			meta.RegisterMemberProperty(15114, new CStaticMemberProperty<ushort>("s1", delegate(ushort value) { org.gof.worldsrv.MyAgent.s1 = value; }, delegate() { return org.gof.worldsrv.MyAgent.s1; }));
			meta.RegisterMemberProperty(15115, new CStaticMemberProperty<long>("s2", delegate(long value) {  }, delegate() { return org.gof.worldsrv.MyAgent._get_s2(); }));
			meta.RegisterMemberProperty(15507, new CMemberProperty<behaviac.EBTStatus>("v1", delegate(Agent self, behaviac.EBTStatus value) { ((org.gof.worldsrv.MyAgent)self)._set_v1(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v1(); }));
			meta.RegisterMemberProperty(2031466, new CMemberProperty<List<behaviac.EBTStatus>>("v11", delegate(Agent self, List<behaviac.EBTStatus> value) { ((org.gof.worldsrv.MyAgent)self)._set_v11(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v11(); }));
			meta.RegisterMemberProperty(502261672, new CMemberArrayItemProperty<behaviac.EBTStatus>("v11[]", delegate(Agent self, behaviac.EBTStatus value, int index) { ((org.gof.worldsrv.MyAgent)self)._get_v11()[index] = value; }, delegate(Agent self, int index) { return ((org.gof.worldsrv.MyAgent)self)._get_v11()[index]; }));
			meta.RegisterMemberProperty(2031467, new CMemberProperty<List<bool>>("v12", delegate(Agent self, List<bool> value) { ((org.gof.worldsrv.MyAgent)self)._set_v12(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v12(); }));
			meta.RegisterMemberProperty(502278833, new CMemberArrayItemProperty<bool>("v12[]", delegate(Agent self, bool value, int index) { ((org.gof.worldsrv.MyAgent)self)._get_v12()[index] = value; }, delegate(Agent self, int index) { return ((org.gof.worldsrv.MyAgent)self)._get_v12()[index]; }));
			meta.RegisterMemberProperty(2031468, new CMemberProperty<int>("v13", delegate(Agent self, int value) { ((org.gof.worldsrv.MyAgent)self)._set_v13(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v13(); }));
			meta.RegisterMemberProperty(2031469, new CMemberProperty<float>("v14", delegate(Agent self, float value) { ((org.gof.worldsrv.MyAgent)self)._set_v14(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v14(); }));
			meta.RegisterMemberProperty(2031470, new CMemberProperty<double>("v15", delegate(Agent self, double value) { ((org.gof.worldsrv.MyAgent)self)._set_v15(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v15(); }));
			meta.RegisterMemberProperty(2031471, new CMemberProperty<string>("v16", delegate(Agent self, string value) { ((org.gof.worldsrv.MyAgent)self)._set_v16(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v16(); }));
			meta.RegisterMemberProperty(15508, new CMemberProperty<bool>("v2", delegate(Agent self, bool value) { ((org.gof.worldsrv.MyAgent)self)._set_v2(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v2(); }));
			meta.RegisterMemberProperty(15509, new CMemberProperty<int>("v3", delegate(Agent self, int value) { ((org.gof.worldsrv.MyAgent)self)._set_v3(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v3(); }));
			meta.RegisterMemberProperty(15510, new CMemberProperty<uint>("v4", delegate(Agent self, uint value) { ((org.gof.worldsrv.MyAgent)self)._set_v4(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v4(); }));
			meta.RegisterMemberProperty(15511, new CMemberProperty<float>("v5", delegate(Agent self, float value) { ((org.gof.worldsrv.MyAgent)self)._set_v5(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v5(); }));
			meta.RegisterMemberProperty(15512, new CMemberProperty<double>("v6", delegate(Agent self, double value) { ((org.gof.worldsrv.MyAgent)self)._set_v6(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v6(); }));
			meta.RegisterMemberProperty(15513, new CMemberProperty<string>("v7", delegate(Agent self, string value) { ((org.gof.worldsrv.MyAgent)self)._set_v7(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v7(); }));
			meta.RegisterMethod(1396400587, new CAgentStaticMethodVoid<string>(delegate(string param0) { org.gof.worldsrv.MyAgent.LogMessage(param0); }));
			meta.RegisterMethod(14328, new CAgentMethod<behaviac.EBTStatus, bool, uint, float, string, long, List<bool>, List<int>, double>(delegate(Agent self, bool v1, uint v2, float v3, string v4, long v5, List<bool> v11, List<int> v12, double v13) { return ((org.gof.worldsrv.MyAgent)self).m1(v1, v2, v3, v4, v5, v11, v12, v13); }));
			meta.RegisterMethod(1738753698, new CAgentStaticMethodVoid<bool, double>(delegate(bool z1, double z2) { org.gof.worldsrv.MyAgent.StaticMethod1(z1, z2); }));
			meta.RegisterMethod(22304876, new CAgentMethodVoid<List<short>>(delegate(Agent self, List<short> v1) { }) /* task1 */);
			meta.RegisterMethod(1952612959, new CAgentMethodVoid<List<float>, uint>(delegate(Agent self, List<float> z1, uint z2) { ((org.gof.worldsrv.MyAgent)self).testM2(z1, z2); }));
			meta.RegisterMethod(197161586, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(1810246298, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(2025304058, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(348439993, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(2042517019, new CMethod_behaviac_Agent_VectorRemove());

			// testbehaviac.x1.MyAgent2
			meta = new AgentMeta(1495664214);
			AgentMeta._AgentMetas_[1464643067] = meta;
			meta.RegisterMemberProperty(1683652181, new CStaticMemberProperty<List<int>>("haha_z2", delegate(List<int> value) { testbehaviac.x1.MyAgent2.haha_z2 = value; }, delegate() { return testbehaviac.x1.MyAgent2.haha_z2; }));
			meta.RegisterMemberProperty(910089963, new CStaticMemberArrayItemProperty<int>("haha_z2[]", delegate(int value, int index) { testbehaviac.x1.MyAgent2.haha_z2[index] = value; }, delegate(int index) { return testbehaviac.x1.MyAgent2.haha_z2[index]; }));
			meta.RegisterMemberProperty(15114, new CStaticMemberProperty<ushort>("s1", delegate(ushort value) { testbehaviac.x1.MyAgent2.s1 = value; }, delegate() { return testbehaviac.x1.MyAgent2.s1; }));
			meta.RegisterMemberProperty(15115, new CStaticMemberProperty<long>("s2", delegate(long value) {  }, delegate() { return testbehaviac.x1.MyAgent2._get_s2(); }));
			meta.RegisterMemberProperty(1593209488, new CMemberProperty<org.gof.worldsrv.Haha>("testHaha", delegate(Agent self, org.gof.worldsrv.Haha value) { ((testbehaviac.x1.MyAgent2)self).testHaha = value; }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self).testHaha; }));
			meta.RegisterMemberProperty(15507, new CMemberProperty<behaviac.EBTStatus>("v1", delegate(Agent self, behaviac.EBTStatus value) { ((testbehaviac.x1.MyAgent2)self)._set_v1(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v1(); }));
			meta.RegisterMemberProperty(2031466, new CMemberProperty<List<behaviac.EBTStatus>>("v11", delegate(Agent self, List<behaviac.EBTStatus> value) { ((testbehaviac.x1.MyAgent2)self)._set_v11(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v11(); }));
			meta.RegisterMemberProperty(502261672, new CMemberArrayItemProperty<behaviac.EBTStatus>("v11[]", delegate(Agent self, behaviac.EBTStatus value, int index) { ((testbehaviac.x1.MyAgent2)self)._get_v11()[index] = value; }, delegate(Agent self, int index) { return ((testbehaviac.x1.MyAgent2)self)._get_v11()[index]; }));
			meta.RegisterMemberProperty(2031467, new CMemberProperty<List<bool>>("v12", delegate(Agent self, List<bool> value) { ((testbehaviac.x1.MyAgent2)self)._set_v12(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v12(); }));
			meta.RegisterMemberProperty(502278833, new CMemberArrayItemProperty<bool>("v12[]", delegate(Agent self, bool value, int index) { ((testbehaviac.x1.MyAgent2)self)._get_v12()[index] = value; }, delegate(Agent self, int index) { return ((testbehaviac.x1.MyAgent2)self)._get_v12()[index]; }));
			meta.RegisterMemberProperty(2031468, new CMemberProperty<int>("v13", delegate(Agent self, int value) { ((testbehaviac.x1.MyAgent2)self)._set_v13(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v13(); }));
			meta.RegisterMemberProperty(2031469, new CMemberProperty<float>("v14", delegate(Agent self, float value) { ((testbehaviac.x1.MyAgent2)self)._set_v14(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v14(); }));
			meta.RegisterMemberProperty(2031470, new CMemberProperty<double>("v15", delegate(Agent self, double value) { ((testbehaviac.x1.MyAgent2)self)._set_v15(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v15(); }));
			meta.RegisterMemberProperty(2031471, new CMemberProperty<string>("v16", delegate(Agent self, string value) { ((testbehaviac.x1.MyAgent2)self)._set_v16(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v16(); }));
			meta.RegisterMemberProperty(15508, new CMemberProperty<bool>("v2", delegate(Agent self, bool value) { ((testbehaviac.x1.MyAgent2)self)._set_v2(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v2(); }));
			meta.RegisterMemberProperty(15509, new CMemberProperty<int>("v3", delegate(Agent self, int value) { ((testbehaviac.x1.MyAgent2)self)._set_v3(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v3(); }));
			meta.RegisterMemberProperty(15510, new CMemberProperty<uint>("v4", delegate(Agent self, uint value) { ((testbehaviac.x1.MyAgent2)self)._set_v4(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v4(); }));
			meta.RegisterMemberProperty(15511, new CMemberProperty<float>("v5", delegate(Agent self, float value) { ((testbehaviac.x1.MyAgent2)self)._set_v5(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v5(); }));
			meta.RegisterMemberProperty(15512, new CMemberProperty<double>("v6", delegate(Agent self, double value) { ((testbehaviac.x1.MyAgent2)self)._set_v6(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v6(); }));
			meta.RegisterMemberProperty(15513, new CMemberProperty<string>("v7", delegate(Agent self, string value) { ((testbehaviac.x1.MyAgent2)self)._set_v7(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_v7(); }));
			meta.RegisterMemberProperty(1247657123, new CMemberProperty<org.gof.worldsrv.StructTest>("vstruct", delegate(Agent self, org.gof.worldsrv.StructTest value) { ((testbehaviac.x1.MyAgent2)self)._set_vstruct(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_vstruct(); }));
			meta.RegisterMemberProperty(271846009, new CMemberProperty<uint>("xxx1", delegate(Agent self, uint value) { ((testbehaviac.x1.MyAgent2)self)._set_xxx1(value); }, delegate(Agent self) { return ((testbehaviac.x1.MyAgent2)self)._get_xxx1(); }));
			meta.RegisterMethod(1396400587, new CAgentStaticMethodVoid<string>(delegate(string param0) { testbehaviac.x1.MyAgent2.LogMessage(param0); }));
			meta.RegisterMethod(14328, new CAgentMethod<behaviac.EBTStatus, bool, uint, float, string, long, List<bool>, List<int>, double>(delegate(Agent self, bool v1, uint v2, float v3, string v4, long v5, List<bool> v11, List<int> v12, double v13) { return ((testbehaviac.x1.MyAgent2)self).m1(v1, v2, v3, v4, v5, v11, v12, v13); }));
			meta.RegisterMethod(206889707, new CMethod_testbehaviac_x1_MyAgent2_methodHaha());
			meta.RegisterMethod(1738753698, new CAgentStaticMethodVoid<bool, double>(delegate(bool z1, double z2) { testbehaviac.x1.MyAgent2.StaticMethod1(z1, z2); }));
			meta.RegisterMethod(22304876, new CAgentMethodVoid<List<short>>(delegate(Agent self, List<short> v1) { }) /* task1 */);
			meta.RegisterMethod(1952612959, new CAgentMethodVoid<List<float>, uint>(delegate(Agent self, List<float> z1, uint z2) { ((testbehaviac.x1.MyAgent2)self).testM2(z1, z2); }));
			meta.RegisterMethod(197161586, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(1810246298, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(2025304058, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(348439993, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(2042517019, new CMethod_behaviac_Agent_VectorRemove());
			meta.RegisterMethod(276376776, new CAgentMethodVoid<int>(delegate(Agent self, int x1) { ((testbehaviac.x1.MyAgent2)self).zzz2(x1); }));

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<org.gof.worldsrv.MyAgent>("org.gof.worldsrv.MyAgent");
			AgentMeta.Register<testbehaviac.x1.MyAgent2>("testbehaviac.x1.MyAgent2");
			AgentMeta.Register<org.gof.worldsrv.EnumTest>("org.gof.worldsrv.EnumTest");
			ComparerRegister.RegisterType<org.gof.worldsrv.EnumTest, CompareValue_org_gof_worldsrv_EnumTest>();
			AgentMeta.Register<org.gof.worldsrv.StructTest>("org.gof.worldsrv.StructTest");
			ComparerRegister.RegisterType<org.gof.worldsrv.StructTest, CompareValue_org_gof_worldsrv_StructTest>();
			AgentMeta.Register<org.gof.worldsrv.Haha>("org.gof.worldsrv.Haha");
			ComparerRegister.RegisterType<org.gof.worldsrv.Haha, CompareValue_org_gof_worldsrv_Haha>();
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<org.gof.worldsrv.MyAgent>("org.gof.worldsrv.MyAgent");
			AgentMeta.UnRegister<testbehaviac.x1.MyAgent2>("testbehaviac.x1.MyAgent2");
			AgentMeta.UnRegister<org.gof.worldsrv.EnumTest>("org.gof.worldsrv.EnumTest");
			AgentMeta.UnRegister<org.gof.worldsrv.StructTest>("org.gof.worldsrv.StructTest");
			AgentMeta.UnRegister<org.gof.worldsrv.Haha>("org.gof.worldsrv.Haha");
			return true;
		}
	}
}
