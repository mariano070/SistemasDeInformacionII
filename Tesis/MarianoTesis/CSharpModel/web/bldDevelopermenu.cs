using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "Developermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

