/*
               File: M124FPROVUpdateReferentialIntegrity
        Description: Load referential integrity
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:42:26.40
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class m124fprovupdatereferentialintegrity : GXProcedure
   {
      public m124fprovupdatereferentialintegrity( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public m124fprovupdatereferentialintegrity( IGxContext context )
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

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         m124fprovupdatereferentialintegrity objm124fprovupdatereferentialintegrity;
         objm124fprovupdatereferentialintegrity = new m124fprovupdatereferentialintegrity();
         objm124fprovupdatereferentialintegrity.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objm124fprovupdatereferentialintegrity.executePrivateCatch ));
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
         /* Using cursor M124FPROVU2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A27TTBUS_CodProveedor = M124FPROVU2_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = M124FPROVU2_n27TTBUS_CodProveedor[0] ;
            A30TTBUS_DesProveedor = M124FPROVU2_A30TTBUS_DesProveedor[0] ;
            A11TTBUS_Id = M124FPROVU2_A11TTBUS_Id[0] ;
            /*
               INSERT RECORD ON TABLE M124FPROV

            */
            if ( M124FPROVU2_n27TTBUS_CodProveedor[0] )
            {
               A28PV_NPRO = 0 ;
            }
            else
            {
               A28PV_NPRO = A27TTBUS_CodProveedor ;
            }
            A5PV_DESC = A30TTBUS_DesProveedor ;
            /* Using cursor M124FPROVU3 */
            pr_default.execute(1, new Object[] {A28PV_NPRO, A5PV_DESC});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
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
         M124FPROVU2_A27TTBUS_CodProveedor = new int[1] ;
         M124FPROVU2_n27TTBUS_CodProveedor = new bool[] {false} ;
         M124FPROVU2_A30TTBUS_DesProveedor = new String[] {""} ;
         M124FPROVU2_A11TTBUS_Id = new int[1] ;
         A30TTBUS_DesProveedor = "" ;
         A5PV_DESC = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.m124fprovupdatereferentialintegrity__default(),
            new Object[][] {
                new Object[] {
               M124FPROVU2_A27TTBUS_CodProveedor, M124FPROVU2_n27TTBUS_CodProveedor, M124FPROVU2_A30TTBUS_DesProveedor, M124FPROVU2_A11TTBUS_Id
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A27TTBUS_CodProveedor ;
      private int A11TTBUS_Id ;
      private int GX_INS41 ;
      private int A28PV_NPRO ;
      private String scmdbuf ;
      private String A30TTBUS_DesProveedor ;
      private String A5PV_DESC ;
      private String Gx_emsg ;
      private bool n27TTBUS_CodProveedor ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] M124FPROVU2_A27TTBUS_CodProveedor ;
      private bool[] M124FPROVU2_n27TTBUS_CodProveedor ;
      private String[] M124FPROVU2_A30TTBUS_DesProveedor ;
      private int[] M124FPROVU2_A11TTBUS_Id ;
   }

   public class m124fprovupdatereferentialintegrity__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmM124FPROVU2 ;
          prmM124FPROVU2 = new Object[] {
          } ;
          Object[] prmM124FPROVU3 ;
          prmM124FPROVU3 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PV_DESC",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("M124FPROVU2", "SELECT [TTBUS_CodProveedor], [TTBUS_DesProveedor], [TTBUS_Id] FROM [TTBUS000] ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmM124FPROVU2,100,0,true,false )
             ,new CursorDef("M124FPROVU3", "INSERT INTO [M124FPROV] ([PV_NPRO], [PV_DESC]) VALUES (@PV_NPRO, @PV_DESC)", GxErrorMask.GX_NOMASK,prmM124FPROVU3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 30) ;
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
