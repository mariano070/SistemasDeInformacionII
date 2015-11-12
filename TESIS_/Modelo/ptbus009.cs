/*
               File: PTBUS009
        Description: Busca nº de etiqueta de fondo fijo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:15.77
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
   public class ptbus009 : GXProcedure
   {
      public ptbus009( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus009( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_TTBUS_Id ,
                           int aP1_IdIdentificador ,
                           out String aP2_NumeroIdentificador )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV10IdIdentificador = aP1_IdIdentificador;
         this.AV9NumeroIdentificador = "" ;
         initialize();
         executePrivate();
         aP2_NumeroIdentificador=this.AV9NumeroIdentificador;
      }

      public String executeUdp( int aP0_TTBUS_Id ,
                                int aP1_IdIdentificador )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV10IdIdentificador = aP1_IdIdentificador;
         this.AV9NumeroIdentificador = "" ;
         initialize();
         executePrivate();
         aP2_NumeroIdentificador=this.AV9NumeroIdentificador;
         return AV9NumeroIdentificador ;
      }

      public void executeSubmit( int aP0_TTBUS_Id ,
                                 int aP1_IdIdentificador ,
                                 out String aP2_NumeroIdentificador )
      {
         ptbus009 objptbus009;
         objptbus009 = new ptbus009();
         objptbus009.AV8TTBUS_Id = aP0_TTBUS_Id;
         objptbus009.AV10IdIdentificador = aP1_IdIdentificador;
         objptbus009.AV9NumeroIdentificador = "" ;
         objptbus009.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus009.executePrivateCatch ));
         aP2_NumeroIdentificador=this.AV9NumeroIdentificador;
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
         AV9NumeroIdentificador = "" ;
         /* Using cursor P00102 */
         pr_default.execute(0, new Object[] {AV8TTBUS_Id, AV10IdIdentificador});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A14IdIdentificador = P00102_A14IdIdentificador[0] ;
            A11TTBUS_Id = P00102_A11TTBUS_Id[0] ;
            A15NumeroIdentificador = P00102_A15NumeroIdentificador[0] ;
            AV9NumeroIdentificador = A15NumeroIdentificador ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         P00102_A14IdIdentificador = new int[1] ;
         P00102_A11TTBUS_Id = new int[1] ;
         P00102_A15NumeroIdentificador = new String[] {""} ;
         A15NumeroIdentificador = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus009__default(),
            new Object[][] {
                new Object[] {
               P00102_A14IdIdentificador, P00102_A11TTBUS_Id, P00102_A15NumeroIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV8TTBUS_Id ;
      private int AV10IdIdentificador ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private String scmdbuf ;
      private String AV9NumeroIdentificador ;
      private String A15NumeroIdentificador ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P00102_A14IdIdentificador ;
      private int[] P00102_A11TTBUS_Id ;
      private String[] P00102_A15NumeroIdentificador ;
      private String aP2_NumeroIdentificador ;
   }

   public class ptbus009__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00102 ;
          prmP00102 = new Object[] {
          new Object[] {"@AV8TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV10IdIdentificador",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00102", "SELECT [IdIdentificador], [TTBUS_Id], [NumeroIdentificador] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV8TTBUS_Id and [IdIdentificador] = @AV10IdIdentificador ORDER BY [TTBUS_Id], [IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00102,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                break;
       }
    }

 }

}
