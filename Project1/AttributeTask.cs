using Project1.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Project1.Attribute.CustomTest;

namespace Project1
{
    public class AttributeTask : ITask
    {
        public void Run()
        {
            Console.WriteLine("-----Class-----");
            Type t = typeof(CustomTest.Test1);
            foreach (Object attributes in t.GetCustomAttributes(false))
            {
                var dbi = (DebugInfo)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.id);
                    Console.WriteLine("Developer: {0}", dbi.developer);
                    Console.WriteLine("Last Reviewed: {0}",
                                             dbi.lastReview);
                    Console.WriteLine("Remarks: {0}", dbi.msg);
                }
            }

            // 遍历方法特性
            Console.WriteLine("\n-----MethodInfo-----\n");
            foreach (MethodInfo m in t.GetMethods())
            {
                foreach (Object a in m.GetCustomAttributes(true))
                {
                    if(a is DebugInfo)
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for Method: {1}",
                                                          dbi.id, m.Name);
                            Console.WriteLine("Developer: {0}", dbi.developer);
                            Console.WriteLine("Last Reviewed: {0}",
                                                          dbi.lastReview);
                            Console.WriteLine("Remarks: {0}", dbi.msg);
                        }
                    }                   
                }
            }

            // 
            Console.WriteLine("\n-----MemberInfo-----\n");
            foreach(MemberInfo meb in t.GetMembers())
            {
                foreach (Object a in meb.GetCustomAttributes(true))
                {
                    if (a is DebugInfo)
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for MemberInfo: {1}",
                                                          dbi.id, meb.Name);
                            Console.WriteLine("Developer: {0}", dbi.developer);
                            Console.WriteLine("Last Reviewed: {0}",
                                                          dbi.lastReview);
                            Console.WriteLine("Remarks: {0}", dbi.msg);
                        }
                    }
                }
            }

            Console.WriteLine("\n-----PropertyInfo-----\n");
            foreach (PropertyInfo meb in t.GetProperties())
            {
                foreach (Object a in meb.GetCustomAttributes(true))
                {
                    if (a is DebugInfo)
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for PropertyInfo: {1}",
                                                          dbi.id, meb.Name);
                            Console.WriteLine("Developer: {0}", dbi.developer);
                            Console.WriteLine("Last Reviewed: {0}",
                                                          dbi.lastReview);
                            Console.WriteLine("Remarks: {0}", dbi.msg);
                        }
                    }
                }
            }
            
            Console.WriteLine("\n-----FieldInfo-----\n");
            foreach (var meb in t.GetFields())
            {
                foreach (Object a in meb.GetCustomAttributes(true))
                {
                    if (a is DebugInfo)
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for FieldInfo: {1}",
                                                          dbi.id, meb.Name);
                            Console.WriteLine("Developer: {0}", dbi.developer);
                            Console.WriteLine("Last Reviewed: {0}",
                                                          dbi.lastReview);
                            Console.WriteLine("Remarks: {0}", dbi.msg);
                        }
                    }
                }
            }

            Console.WriteLine("\n-----ConstructorInfo-----\n");
            foreach (var meb in t.GetConstructors())
            {
                foreach (Object a in meb.GetCustomAttributes(true))
                {
                    if (a is DebugInfo)
                    {
                        DebugInfo dbi = (DebugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for ConstructorInfo: {1}",
                                                          dbi.id, meb.Name);
                            Console.WriteLine("Developer: {0}", dbi.developer);
                            Console.WriteLine("Last Reviewed: {0}",
                                                          dbi.lastReview);
                            Console.WriteLine("Remarks: {0}", dbi.msg);
                        }
                    }
                }
            }
        }
    }
}
