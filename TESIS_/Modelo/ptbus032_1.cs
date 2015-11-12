/*
               File: PTBUS032_1
        Description: Controles de validez de asociación Hardware - Trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:14.63
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
   public class ptbus032_1 : GXProcedure
   {
      public ptbus032_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus032_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_HARDWARE_ID ,
                           int aP1_HDW_IDT ,
                           out short aP2_error ,
                           out String aP3_mensaje )
      {
         this.AV11HARDWARE_ID = aP0_HARDWARE_ID;
         this.AV8HDW_IDT = aP1_HDW_IDT;
         this.AV10error = 0 ;
         this.AV9mensaje = "" ;
         initialize();
         executePrivate();
         aP2_error=this.AV10error;
         aP3_mensaje=this.AV9mensaje;
      }

      public String executeUdp( short aP0_HARDWARE_ID ,
                                int aP1_HDW_IDT ,
                                out short aP2_error )
      {
         this.AV11HARDWARE_ID = aP0_HARDWARE_ID;
         this.AV8HDW_IDT = aP1_HDW_IDT;
         this.AV10error = 0 ;
         this.AV9mensaje = "" ;
         initialize();
         executePrivate();
         aP2_error=this.AV10error;
         aP3_mensaje=this.AV9mensaje;
         return AV9mensaje ;
      }

      public void executeSubmit( short aP0_HARDWARE_ID ,
                                 int aP1_HDW_IDT ,
                                 out short aP2_error ,
                                 out String aP3_mensaje )
      {
         ptbus032_1 objptbus032_1;
         objptbus032_1 = new ptbus032_1();
         objptbus032_1.AV11HARDWARE_ID = aP0_HARDWARE_ID;
         objptbus032_1.AV8HDW_IDT = aP1_HDW_IDT;
         objptbus032_1.AV10error = 0 ;
         objptbus032_1.AV9mensaje = "" ;
         objptbus032_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus032_1.executePrivateCatch ));
         aP2_error=this.AV10error;
         aP3_mensaje=this.AV9mensaje;
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
         AV10error = 0 ;
         AV12band = 0 ;
         AV15GXLvl6 = 0 ;
         /* Using cursor P001T2 */
         pr_default.execute(0, new Object[] {AV8HDW_IDT});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11TTBUS_Id = P001T2_A11TTBUS_Id[0] ;
            AV15GXLvl6 = 1 ;
            AV12band = 1 ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV15GXLvl6 == 0 )
         {
            AV10error = 1 ;
            AV9mensaje = "EL NÚMERO DE BIEN " + StringUtil.Trim( StringUtil.Str( (decimal)(AV8HDW_IDT), 8, 0)) + " NO EXISTE EN TRAZABILIDAD DE BIENES DE USO." ;
         }
         if ( AV12band == 1 )
         {
            /* Using cursor P001T3 */
            pr_default.execute(1, new Object[] {AV11HARDWARE_ID, AV8HDW_IDT});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A104HDW_IDT = P001T3_A104HDW_IDT[0] ;
               A10HARDWARE_ID = P001T3_A10HARDWARE_ID[0] ;
               AV10error = 1 ;
               AV9mensaje = "EL HARDWARE Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)) + " YA ESTÁ ASOCIADO AL BIEN DE USO Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(AV8HDW_IDT), 8, 0)) + "." ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         P001T2_A11TTBUS_Id = new int[1] ;
         P001T3_A104HDW_IDT = new int[1] ;
         P001T3_A10HARDWARE_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus032_1__default(),
            new Object[][] {
                new Object[] {
               P001T2_A11TTBUS_Id
               }
               , new Object[] {
               P001T3_A104HDW_IDT, P001T3_A10HARDWARE_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11HARDWARE_ID ;
      private short AV10error ;
      private short AV12band ;
      private short AV15GXLvl6 ;
      private short A10HARDWARE_ID ;
      private int AV8HDW_IDT ;
      private int A11TTBUS_Id ;
      private int A104HDW_IDT ;
      private String AV9mensaje ;
      private String scmdbuf ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P001T2_A11TTBUS_Id ;
      private int[] P001T3_A104HDW_IDT ;
      private short[] P001T3_A10HARDWARE_ID ;
      private short aP2_error ;
      private String aP3_mensaje ;
   }

   public class ptbus032_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001T2 ;
          prmP001T2 = new Object[] {
          new Object[] {"@AV8HDW_IDT",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001T3 ;
          prmP001T3 = new Object[] {
          new Object[] {"@AV11HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8HDW_IDT",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001T2", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV8HDW_IDT ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T2,1,0,false,true )
             ,new CursorDef("P001T3", "SELECT TOP 1 [HDW_IDT], [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) WHERE ([HARDWARE_ID] <> @AV11HARDWARE_ID) AND ([HDW_IDT] = @AV8HDW_IDT) ORDER BY [HARDWARE_ID], [HDW_IDT] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T3,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
