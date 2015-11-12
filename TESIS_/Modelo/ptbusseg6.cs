/*
               File: PTBUSSEG6
        Description: Elimina usuario de la SEG002
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:13.2
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
   public class ptbusseg6 : GXProcedure
   {
      public ptbusseg6( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg6( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD ,
                           ref String aP1_SISTEMA ,
                           ref String aP2_USUARIO )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9SISTEMA = aP1_SISTEMA;
         this.AV10USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_SISTEMA=this.AV9SISTEMA;
         aP2_USUARIO=this.AV10USUARIO;
      }

      public String executeUdp( ref String aP0_USU_COD ,
                                ref String aP1_SISTEMA )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9SISTEMA = aP1_SISTEMA;
         this.AV10USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_SISTEMA=this.AV9SISTEMA;
         aP2_USUARIO=this.AV10USUARIO;
         return AV10USUARIO ;
      }

      public void executeSubmit( ref String aP0_USU_COD ,
                                 ref String aP1_SISTEMA ,
                                 ref String aP2_USUARIO )
      {
         ptbusseg6 objptbusseg6;
         objptbusseg6 = new ptbusseg6();
         objptbusseg6.AV8USU_COD = aP0_USU_COD;
         objptbusseg6.AV9SISTEMA = aP1_SISTEMA;
         objptbusseg6.AV10USUARIO = aP2_USUARIO;
         objptbusseg6.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg6.executePrivateCatch ));
         aP0_USU_COD=this.AV8USU_COD;
         aP1_SISTEMA=this.AV9SISTEMA;
         aP2_USUARIO=this.AV10USUARIO;
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
         /* Using cursor P002S2 */
         pr_default.execute(0, new Object[] {AV8USU_COD});
         pr_default.close(0);
         /* End optimized DELETE. */
         context.wjLoc = "hseg102.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV10USUARIO)) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG6");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg6__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV8USU_COD ;
      private String AV9SISTEMA ;
      private String AV10USUARIO ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private String aP1_SISTEMA ;
      private String aP2_USUARIO ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbusseg6__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002S2 ;
          prmP002S2 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002S2", "DELETE FROM [SEG002]  WHERE [USU_COD] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002S2)
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
