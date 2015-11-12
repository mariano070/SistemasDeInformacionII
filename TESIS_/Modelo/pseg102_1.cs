/*
               File: PSEG102_1
        Description: Borrado de asociaciones de zonas de promoción a usuarios
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:13.39
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
   public class pseg102_1 : GXProcedure
   {
      public pseg102_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg102_1( IGxContext context )
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

      public void execute( ref String aP0_PRM5_USU )
      {
         this.AV8PRM5_USU = aP0_PRM5_USU;
         initialize();
         executePrivate();
         aP0_PRM5_USU=this.AV8PRM5_USU;
      }

      public String executeUdp( )
      {
         this.AV8PRM5_USU = aP0_PRM5_USU;
         initialize();
         executePrivate();
         aP0_PRM5_USU=this.AV8PRM5_USU;
         return AV8PRM5_USU ;
      }

      public void executeSubmit( ref String aP0_PRM5_USU )
      {
         pseg102_1 objpseg102_1;
         objpseg102_1 = new pseg102_1();
         objpseg102_1.AV8PRM5_USU = aP0_PRM5_USU;
         objpseg102_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg102_1.executePrivateCatch ));
         aP0_PRM5_USU=this.AV8PRM5_USU;
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
         /* Optimized DELETE. */
         /* Using cursor P002H2 */
         pr_default.execute(0, new Object[] {AV8PRM5_USU});
         pr_default.close(0);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG102_1");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg102_1__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV8PRM5_USU ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_PRM5_USU ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg102_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002H2 ;
          prmP002H2 = new Object[] {
          new Object[] {"@AV8PRM5_USU",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002H2", "DELETE FROM [TPRM005]  WHERE [PRM5_USU] = @AV8PRM5_USU", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002H2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
       }
    }

 }

}
