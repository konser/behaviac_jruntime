﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

package testbehaviac.x1;

import org.gof.behaviac.*;
import java.util.List;
import java.util.ArrayList;

///<<< BEGIN WRITING YOUR CODE FILE_INIT

///<<< END WRITING YOUR CODE

///<<< BEGIN WRITING YOUR CODE NAMESPACE_INIT

///<<< END WRITING YOUR CODE

public class MyAgent2 extends org.gof.worldsrv.MyAgent
///<<< BEGIN WRITING YOUR CODE MyAgent2
///<<< END WRITING YOUR CODE
{
	public static ArrayList<Integer> haha_z2 = new ArrayList<Integer>();
	public IProperty CreateStaticProperty_HAHA_Z2() {
		CStaticMemberProperty.Getter getter = ()-> { return testbehaviac.x1.MyAgent2.haha_z2; };
		CStaticMemberProperty.Setter setter = (_obj)-> { testbehaviac.x1.MyAgent2.haha_z2 = (ArrayList<Integer>)_obj; };
		CStaticMemberProperty prop = new CStaticMemberProperty("haha_z2", new ClassInfo(true,Integer.class), getter, setter);
		return prop;
	}

	public IProperty CreateStaticArrayProperty_HAHA_Z2() {
		CStaticArrayItemProperty.Getter getter = (_index)-> { return testbehaviac.x1.MyAgent2.haha_z2.get(_index); };
		CStaticArrayItemProperty.Setter setter = (_obj)-> { testbehaviac.x1.MyAgent2.haha_z2.set(_index,(Integer)_obj); };
		CStaticArrayItemProperty prop = new CStaticArrayItemProperty("haha_z2[]", new ClassInfo(true,Integer.class), getter, setter);
		return prop;
	}

	private int xxx1 = 0;
	public void _set_xxx1(int value)
	{
		xxx1 = value;
	}
	public int _get_xxx1()
	{
		return xxx1;
	}
	public IProperty CreateMemberProperty_XXX1() {
		CMemberProperty.Getter getter = (_agent)-> { return ((testbehaviac.x1.MyAgent2)_agent).xxx1; };
		CMemberProperty.Setter setter = (_agent,_obj)-> { ((testbehaviac.x1.MyAgent2)_agent).xxx1 = (Integer)_obj; };
		CMemberProperty prop = new CMemberProperty("xxx1", new ClassInfo(Integer.class), getter, setter);
		return prop;
	}

	public void zzz2(Integer x1)
	{
///<<< BEGIN WRITING YOUR CODE zzz2
///<<< END WRITING YOUR CODE
	}

	public static IMethod CreateMemberMethod_ZZZ2() {
		return new CAgentMethodVoid1<Integer>((Agent _agent,Integer x1)->{ ((testbehaviac.x1.MyAgent2)_agent).zzz2(x1);});
	}
///<<< BEGIN WRITING YOUR CODE CLASS_PART

///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE NAMESPACE_UNINIT

///<<< END WRITING YOUR CODE

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

