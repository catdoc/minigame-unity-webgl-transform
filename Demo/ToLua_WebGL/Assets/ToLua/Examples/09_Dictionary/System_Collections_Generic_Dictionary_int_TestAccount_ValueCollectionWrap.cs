﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Collections_Generic_Dictionary_int_TestAccount_ValueCollectionWrap
{
    public static void Register(LuaState L)
    {
        L.BeginClass(
            typeof(System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection),
            typeof(System.Object),
            "ValueCollection"
        );
        L.RegFunction("CopyTo", CopyTo);
        L.RegFunction("GetEnumerator", GetEnumerator);
        L.RegFunction(
            "New",
            _CreateSystem_Collections_Generic_Dictionary_int_TestAccount_ValueCollection
        );
        L.RegFunction("__tostring", ToLua.op_ToString);
        L.RegVar("Count", get_Count, null);
        L.EndClass();
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int _CreateSystem_Collections_Generic_Dictionary_int_TestAccount_ValueCollection(
        IntPtr L
    )
    {
        try
        {
            int count = LuaDLL.lua_gettop(L);

            if (count == 1)
            {
                System.Collections.Generic.Dictionary<int, TestAccount> arg0 =
                    (System.Collections.Generic.Dictionary<int, TestAccount>)
                        ToLua.CheckObject(
                            L,
                            1,
                            typeof(System.Collections.Generic.Dictionary<int, TestAccount>)
                        );
                System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection obj =
                    new System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection(
                        arg0
                    );
                ToLua.PushSealed(L, obj);
                return 1;
            }
            else
            {
                return LuaDLL.luaL_throw(
                    L,
                    "invalid arguments to ctor method: System.Collections.Generic.Dictionary<int,TestAccount>.ValueCollection.New"
                );
            }
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int CopyTo(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 3);
            System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection obj =
                (System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection)
                    ToLua.CheckObject(
                        L,
                        1,
                        typeof(System.Collections.Generic.Dictionary<
                            int,
                            TestAccount
                        >.ValueCollection)
                    );
            TestAccount[] arg0 = ToLua.CheckObjectArray<TestAccount>(L, 2);
            int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
            obj.CopyTo(arg0, arg1);
            return 0;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int GetEnumerator(IntPtr L)
    {
        try
        {
            ToLua.CheckArgsCount(L, 1);
            System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection obj =
                (System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection)
                    ToLua.CheckObject(
                        L,
                        1,
                        typeof(System.Collections.Generic.Dictionary<
                            int,
                            TestAccount
                        >.ValueCollection)
                    );
            System.Collections.IEnumerator o = obj.GetEnumerator();
            ToLua.Push(L, o);
            return 1;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int get_Count(IntPtr L)
    {
        object o = null;

        try
        {
            o = ToLua.ToObject(L, 1);
            System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection obj =
                (System.Collections.Generic.Dictionary<int, TestAccount>.ValueCollection)o;
            int ret = obj.Count;
            LuaDLL.lua_pushinteger(L, ret);
            return 1;
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e, o, "attempt to index Count on a nil value");
        }
    }
}
