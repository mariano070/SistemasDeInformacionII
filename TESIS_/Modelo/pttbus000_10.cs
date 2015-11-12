/*
               File: PTTBUS000_10
        Description: Control de identificadores duplicados
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:3.81
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
   public class pttbus000_10 : GXProcedure
   {
      public pttbus000_10( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_10( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_pTTBUS_Id ,
                           int aP1_pIdIdentificador ,
                           String aP2_pNumeroIdentificador ,
                           out short aP3_error ,
                           out String aP4_mensaje )
      {
         this.AV10pTTBUS_Id = aP0_pTTBUS_Id;
         this.AV9pIdIdentificador = aP1_pIdIdentificador;
         this.AV8pNumeroIdentificador = aP2_pNumeroIdentificador;
         this.AV12error = 0 ;
         this.AV11mensaje = "" ;
         initialize();
         executePrivate();
         aP3_error=this.AV12error;
         aP4_mensaje=this.AV11mensaje;
      }

      public String executeUdp( int aP0_pTTBUS_Id ,
                                int aP1_pIdIdentificador ,
                                String aP2_pNumeroIdentificador ,
                                out short aP3_error )
      {
         this.AV10pTTBUS_Id = aP0_pTTBUS_Id;
         this.AV9pIdIdentificador = aP1_pIdIdentificador;
         this.AV8pNumeroIdentificador = aP2_pNumeroIdentificador;
         this.AV12error = 0 ;
         this.AV11mensaje = "" ;
         initialize();
         executePrivate();
         aP3_error=this.AV12error;
         aP4_mensaje=this.AV11mensaje;
         return AV11mensaje ;
      }

      public void executeSubmit( int aP0_pTTBUS_Id ,
                                 int aP1_pIdIdentificador ,
                                 String aP2_pNumeroIdentificador ,
                                 out short aP3_error ,
                                 out String aP4_mensaje )
      {
         pttbus000_10 objpttbus000_10;
         objpttbus000_10 = new pttbus000_10();
         objpttbus000_10.AV10pTTBUS_Id = aP0_pTTBUS_Id;
         objpttbus000_10.AV9pIdIdentificador = aP1_pIdIdentificador;
         objpttbus000_10.AV8pNumeroIdentificador = aP2_pNumeroIdentificador;
         objpttbus000_10.AV12error = 0 ;
         objpttbus000_10.AV11mensaje = "" ;
         objpttbus000_10.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_10.executePrivateCatch ));
         aP3_error=this.AV12error;
         aP4_mensaje=this.AV11mensaje;
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
         AV12error = 0 ;
         AV11mensaje = "" ;
         /* Using cursor P00092 */
         pr_default.execute(0, new Object[] {AV10pTTBUS_Id, AV9pIdIdentificador, AV8pNumeroIdentificador});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A15NumeroIdentificador = P00092_A15NumeroIdentificador[0] ;
            A14IdIdentificador = P00092_A14IdIdentificador[0] ;
            A11TTBUS_Id = P00092_A11TTBUS_Id[0] ;
            AV12error = 1 ;
            AV13TTBUS_Id = A11TTBUS_Id ;
            /* Execute user subroutine: S1117 */
            S1117 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12error == 1 )
         {
            AV11mensaje = "EL BIEN DE USO Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(AV13TTBUS_Id), 8, 0)) + " YA TIENE ASIGNADO EL IDENTIFICADOR DE TIPO \"" + AV14TTBUS5_DescIdentificador + "\" Nº " + StringUtil.Trim( AV8pNumeroIdentificador) + "." ;
         }
         this.cleanup();
      }

      protected void S1117( )
      {
         /* 'TIPO IDENTIFICADOR' Routine */
         /* Using cursor P00093 */
         pr_default.execute(1, new Object[] {AV9pIdIdentificador});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A20TTBUS5_IdIdentificador = P00093_A20TTBUS5_IdIdentificador[0] ;
            A21TTBUS5_DescIdentificador = P00093_A21TTBUS5_DescIdentificador[0] ;
            AV14TTBUS5_DescIdentificador = StringUtil.Upper( StringUtil.Trim( A21TTBUS5_DescIdentificador)) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
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
         P00092_A15NumeroIdentificador = new String[] {""} ;
         P00092_A14IdIdentificador = new int[1] ;
         P00092_A11TTBUS_Id = new int[1] ;
         A15NumeroIdentificador = "" ;
         AV14TTBUS5_DescIdentificador = "" ;
         P00093_A20TTBUS5_IdIdentificador = new int[1] ;
         P00093_A21TTBUS5_DescIdentificador = new String[] {""} ;
         A21TTBUS5_DescIdentificador = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_10__default(),
            new Object[][] {
                new Object[] {
               P00092_A15NumeroIdentificador, P00092_A14IdIdentificador, P00092_A11TTBUS_Id
               }
               , new Object[] {
               P00093_A20TTBUS5_IdIdentificador, P00093_A21TTBUS5_DescIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12error ;
      private int AV10pTTBUS_Id ;
      private int AV9pIdIdentificador ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int AV13TTBUS_Id ;
      private int A20TTBUS5_IdIdentificador ;
      private String AV11mensaje ;
      private String scmdbuf ;
      private String AV14TTBUS5_DescIdentificador ;
      private String A21TTBUS5_DescIdentificador ;
      private bool returnInSub ;
      private String AV8pNumeroIdentificador ;
      private String A15NumeroIdentificador ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00092_A15NumeroIdentificador ;
      private int[] P00092_A14IdIdentificador ;
      private int[] P00092_A11TTBUS_Id ;
      private int[] P00093_A20TTBUS5_IdIdentificador ;
      private String[] P00093_A21TTBUS5_DescIdentificador ;
      private short aP3_error ;
      private String aP4_mensaje ;
   }

   public class pttbus000_10__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00092 ;
          prmP00092 = new Object[] {
          new Object[] {"@AV10pTTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV9pIdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8pNumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          Object[] prmP00093 ;
          prmP00093 = new Object[] {
          new Object[] {"@AV9pIdIdentificador",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00092", "SELECT TOP 1 [NumeroIdentificador], [IdIdentificador], [TTBUS_Id] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE ([TTBUS_Id] <> @AV10pTTBUS_Id) AND ([IdIdentificador] = @AV9pIdIdentificador) AND ([NumeroIdentificador] = @AV8pNumeroIdentificador) ORDER BY [TTBUS_Id], [IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00092,1,0,true,true )
             ,new CursorDef("P00093", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @AV9pIdIdentificador ORDER BY [TTBUS5_IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00093,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
