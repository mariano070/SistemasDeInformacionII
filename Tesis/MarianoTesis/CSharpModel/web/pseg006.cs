/*
               File: PSEG006
        Description: COPIA USUARIOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:31:1.72
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pseg006 : GXProcedure
   {
      public pseg006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg006( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUVIE ,
                           ref String aP1_USUNUE )
      {
         this.AV8USUVIE = aP0_USUVIE;
         this.AV9USUNUE = aP1_USUNUE;
         initialize();
         executePrivate();
         aP0_USUVIE=this.AV8USUVIE;
         aP1_USUNUE=this.AV9USUNUE;
      }

      public String executeUdp( ref String aP0_USUVIE )
      {
         this.AV8USUVIE = aP0_USUVIE;
         this.AV9USUNUE = aP1_USUNUE;
         initialize();
         executePrivate();
         aP0_USUVIE=this.AV8USUVIE;
         aP1_USUNUE=this.AV9USUNUE;
         return AV9USUNUE ;
      }

      public void executeSubmit( ref String aP0_USUVIE ,
                                 ref String aP1_USUNUE )
      {
         pseg006 objpseg006;
         objpseg006 = new pseg006();
         objpseg006.AV8USUVIE = aP0_USUVIE;
         objpseg006.AV9USUNUE = aP1_USUNUE;
         objpseg006.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg006.executePrivateCatch ));
         aP0_USUVIE=this.AV8USUVIE;
         aP1_USUNUE=this.AV9USUNUE;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P002G2 */
         pr_default.execute(0, new Object[] {AV8USUVIE});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A116SIS_COD = P002G2_A116SIS_COD[0] ;
            A6USU_COD = P002G2_A6USU_COD[0] ;
            A126PRG_COD = P002G2_A126PRG_COD[0] ;
            W6USU_COD = A6USU_COD ;
            AV10SISCOP = A116SIS_COD ;
            /*
               INSERT RECORD ON TABLE SEG004

            */
            W6USU_COD = A6USU_COD ;
            W116SIS_COD = A116SIS_COD ;
            A6USU_COD = AV9USUNUE ;
            A116SIS_COD = AV10SISCOP ;
            /* Using cursor P002G3 */
            pr_default.execute(1, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            A6USU_COD = W6USU_COD ;
            A116SIS_COD = W116SIS_COD ;
            /* End Insert */
            A6USU_COD = W6USU_COD ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P002G4 */
         pr_default.execute(2, new Object[] {AV8USUVIE});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A126PRG_COD = P002G4_A126PRG_COD[0] ;
            A116SIS_COD = P002G4_A116SIS_COD[0] ;
            A6USU_COD = P002G4_A6USU_COD[0] ;
            W6USU_COD = A6USU_COD ;
            AV10SISCOP = A116SIS_COD ;
            AV11PRGCOP = A126PRG_COD ;
            /*
               INSERT RECORD ON TABLE SEG004

            */
            W6USU_COD = A6USU_COD ;
            W116SIS_COD = A116SIS_COD ;
            W126PRG_COD = A126PRG_COD ;
            A6USU_COD = AV9USUNUE ;
            A116SIS_COD = AV10SISCOP ;
            A126PRG_COD = AV11PRGCOP ;
            /* Using cursor P002G5 */
            pr_default.execute(3, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            pr_default.close(3);
            if ( (pr_default.getStatus(3) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            A6USU_COD = W6USU_COD ;
            A116SIS_COD = W116SIS_COD ;
            A126PRG_COD = W126PRG_COD ;
            /* End Insert */
            A6USU_COD = W6USU_COD ;
            pr_default.readNext(2);
         }
         pr_default.close(2);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG006");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P002G2_A116SIS_COD = new short[1] ;
         P002G2_A6USU_COD = new String[] {""} ;
         P002G2_A126PRG_COD = new short[1] ;
         A6USU_COD = "" ;
         W6USU_COD = "" ;
         Gx_emsg = "" ;
         P002G4_A126PRG_COD = new short[1] ;
         P002G4_A116SIS_COD = new short[1] ;
         P002G4_A6USU_COD = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg006__default(),
            new Object[][] {
                new Object[] {
               P002G2_A116SIS_COD, P002G2_A6USU_COD, P002G2_A126PRG_COD
               }
               , new Object[] {
               }
               , new Object[] {
               P002G4_A126PRG_COD, P002G4_A116SIS_COD, P002G4_A6USU_COD
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short AV10SISCOP ;
      private short W116SIS_COD ;
      private short AV11PRGCOP ;
      private short W126PRG_COD ;
      private int GX_INS21 ;
      private String AV8USUVIE ;
      private String AV9USUNUE ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String W6USU_COD ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private String aP0_USUVIE ;
      private String aP1_USUNUE ;
      private IDataStoreProvider pr_default ;
      private short[] P002G2_A116SIS_COD ;
      private String[] P002G2_A6USU_COD ;
      private short[] P002G2_A126PRG_COD ;
      private short[] P002G4_A126PRG_COD ;
      private short[] P002G4_A116SIS_COD ;
      private String[] P002G4_A6USU_COD ;
   }

   public class pseg006__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002G2 ;
          prmP002G2 = new Object[] {
          new Object[] {"@AV8USUVIE",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002G3 ;
          prmP002G3 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP002G4 ;
          prmP002G4 = new Object[] {
          new Object[] {"@AV8USUVIE",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002G5 ;
          prmP002G5 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002G2", "SELECT [SIS_COD], [USU_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @AV8USUVIE ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002G2,100,1,true,false )
             ,new CursorDef("P002G3", "INSERT INTO [SEG004] ([USU_COD], [SIS_COD], [PRG_COD]) VALUES (@USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmP002G3)
             ,new CursorDef("P002G4", "SELECT [PRG_COD], [SIS_COD], [USU_COD] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @AV8USUVIE ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002G4,100,1,true,false )
             ,new CursorDef("P002G5", "INSERT INTO [SEG004] ([USU_COD], [SIS_COD], [PRG_COD]) VALUES (@USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmP002G5)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
