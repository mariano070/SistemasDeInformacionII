/*
               File: PTBUS032_2
        Description: Controles de validez de asociación Bienes de Uso - Trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:47.33
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
   public class ptbus032_2 : GXProcedure
   {
      public ptbus032_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus032_2( IGxContext context )
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

      public void execute( String aP0_BUS_EMP ,
                           short aP1_BUS_RUB ,
                           short aP2_BUS_COD ,
                           short aP3_BUS_PAR ,
                           int aP4_BUS_IDT ,
                           out short aP5_error ,
                           out String aP6_mensaje )
      {
         this.AV13BUS_EMP = aP0_BUS_EMP;
         this.AV14BUS_RUB = aP1_BUS_RUB;
         this.AV15BUS_COD = aP2_BUS_COD;
         this.AV16BUS_PAR = aP3_BUS_PAR;
         this.AV12BUS_IDT = aP4_BUS_IDT;
         this.AV10error = 0 ;
         this.AV9mensaje = "" ;
         initialize();
         executePrivate();
         aP5_error=this.AV10error;
         aP6_mensaje=this.AV9mensaje;
      }

      public String executeUdp( String aP0_BUS_EMP ,
                                short aP1_BUS_RUB ,
                                short aP2_BUS_COD ,
                                short aP3_BUS_PAR ,
                                int aP4_BUS_IDT ,
                                out short aP5_error )
      {
         this.AV13BUS_EMP = aP0_BUS_EMP;
         this.AV14BUS_RUB = aP1_BUS_RUB;
         this.AV15BUS_COD = aP2_BUS_COD;
         this.AV16BUS_PAR = aP3_BUS_PAR;
         this.AV12BUS_IDT = aP4_BUS_IDT;
         this.AV10error = 0 ;
         this.AV9mensaje = "" ;
         initialize();
         executePrivate();
         aP5_error=this.AV10error;
         aP6_mensaje=this.AV9mensaje;
         return AV9mensaje ;
      }

      public void executeSubmit( String aP0_BUS_EMP ,
                                 short aP1_BUS_RUB ,
                                 short aP2_BUS_COD ,
                                 short aP3_BUS_PAR ,
                                 int aP4_BUS_IDT ,
                                 out short aP5_error ,
                                 out String aP6_mensaje )
      {
         ptbus032_2 objptbus032_2;
         objptbus032_2 = new ptbus032_2();
         objptbus032_2.AV13BUS_EMP = aP0_BUS_EMP;
         objptbus032_2.AV14BUS_RUB = aP1_BUS_RUB;
         objptbus032_2.AV15BUS_COD = aP2_BUS_COD;
         objptbus032_2.AV16BUS_PAR = aP3_BUS_PAR;
         objptbus032_2.AV12BUS_IDT = aP4_BUS_IDT;
         objptbus032_2.AV10error = 0 ;
         objptbus032_2.AV9mensaje = "" ;
         objptbus032_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus032_2.executePrivateCatch ));
         aP5_error=this.AV10error;
         aP6_mensaje=this.AV9mensaje;
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
         AV17band = 0 ;
         AV20GXLvl6 = 0 ;
         /* Using cursor P001U2 */
         pr_default.execute(0, new Object[] {AV12BUS_IDT});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11TTBUS_Id = P001U2_A11TTBUS_Id[0] ;
            AV20GXLvl6 = 1 ;
            AV17band = 1 ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV20GXLvl6 == 0 )
         {
            AV10error = 1 ;
            AV9mensaje = "EL NÚMERO DE BIEN " + StringUtil.Trim( StringUtil.Str( (decimal)(AV12BUS_IDT), 8, 0)) + " NO EXISTE EN TRAZABILIDAD DE BIENES DE USO." ;
         }
         if ( AV17band == 1 )
         {
            /* Using cursor P001U3 */
            pr_default.execute(1, new Object[] {AV12BUS_IDT});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A103BUS_IDT = P001U3_A103BUS_IDT[0] ;
               A4BUS_PAR = P001U3_A4BUS_PAR[0] ;
               A3BUS_COD = P001U3_A3BUS_COD[0] ;
               A1BUS_RUB = P001U3_A1BUS_RUB[0] ;
               A8BUS_EMP = P001U3_A8BUS_EMP[0] ;
               if ( ( StringUtil.StrCmp(A8BUS_EMP, AV13BUS_EMP) != 0 ) || ( A1BUS_RUB != AV14BUS_RUB ) || ( A3BUS_COD != AV15BUS_COD ) || ( A4BUS_PAR != AV16BUS_PAR ) )
               {
                  AV10error = 1 ;
                  AV9mensaje = "EL BIEN EMPRESA " + StringUtil.Trim( A8BUS_EMP) + ", RUBRO " + StringUtil.Trim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)) + ", CÓDIGO " + StringUtil.Trim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)) + ", PARTIDA " + StringUtil.Trim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)) + " YA ESTÁ ASOCIADO AL BIEN DE USO Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(AV12BUS_IDT), 8, 0)) + "." ;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
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
         P001U2_A11TTBUS_Id = new int[1] ;
         P001U3_A103BUS_IDT = new int[1] ;
         P001U3_A4BUS_PAR = new short[1] ;
         P001U3_A3BUS_COD = new short[1] ;
         P001U3_A1BUS_RUB = new short[1] ;
         P001U3_A8BUS_EMP = new String[] {""} ;
         A8BUS_EMP = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus032_2__default(),
            new Object[][] {
                new Object[] {
               P001U2_A11TTBUS_Id
               }
               , new Object[] {
               P001U3_A103BUS_IDT, P001U3_A4BUS_PAR, P001U3_A3BUS_COD, P001U3_A1BUS_RUB, P001U3_A8BUS_EMP
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV14BUS_RUB ;
      private short AV15BUS_COD ;
      private short AV16BUS_PAR ;
      private short AV10error ;
      private short AV17band ;
      private short AV20GXLvl6 ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private int AV12BUS_IDT ;
      private int A11TTBUS_Id ;
      private int A103BUS_IDT ;
      private String AV13BUS_EMP ;
      private String AV9mensaje ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P001U2_A11TTBUS_Id ;
      private int[] P001U3_A103BUS_IDT ;
      private short[] P001U3_A4BUS_PAR ;
      private short[] P001U3_A3BUS_COD ;
      private short[] P001U3_A1BUS_RUB ;
      private String[] P001U3_A8BUS_EMP ;
      private short aP5_error ;
      private String aP6_mensaje ;
   }

   public class ptbus032_2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001U2 ;
          prmP001U2 = new Object[] {
          new Object[] {"@AV12BUS_IDT",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001U3 ;
          prmP001U3 = new Object[] {
          new Object[] {"@AV12BUS_IDT",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001U2", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV12BUS_IDT ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001U2,1,0,false,true )
             ,new CursorDef("P001U3", "SELECT [BUS_IDT], [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP] FROM [BUS000] WITH (NOLOCK) WHERE [BUS_IDT] = @AV12BUS_IDT ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001U3,100,0,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
