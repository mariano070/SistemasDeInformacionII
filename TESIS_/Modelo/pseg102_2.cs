/*
               File: PSEG102_2
        Description: Asociación de Zonas de Promoción a Usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:13.45
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
   public class pseg102_2 : GXProcedure
   {
      public pseg102_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg102_2( IGxContext context )
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

      public void execute( ref String aP0_PRM5_USU ,
                           ref int aP1_PRM5_ZNA )
      {
         this.AV9PRM5_USU = aP0_PRM5_USU;
         this.AV8PRM5_ZNA = aP1_PRM5_ZNA;
         initialize();
         executePrivate();
         aP0_PRM5_USU=this.AV9PRM5_USU;
         aP1_PRM5_ZNA=this.AV8PRM5_ZNA;
      }

      public int executeUdp( ref String aP0_PRM5_USU )
      {
         this.AV9PRM5_USU = aP0_PRM5_USU;
         this.AV8PRM5_ZNA = aP1_PRM5_ZNA;
         initialize();
         executePrivate();
         aP0_PRM5_USU=this.AV9PRM5_USU;
         aP1_PRM5_ZNA=this.AV8PRM5_ZNA;
         return AV8PRM5_ZNA ;
      }

      public void executeSubmit( ref String aP0_PRM5_USU ,
                                 ref int aP1_PRM5_ZNA )
      {
         pseg102_2 objpseg102_2;
         objpseg102_2 = new pseg102_2();
         objpseg102_2.AV9PRM5_USU = aP0_PRM5_USU;
         objpseg102_2.AV8PRM5_ZNA = aP1_PRM5_ZNA;
         objpseg102_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg102_2.executePrivateCatch ));
         aP0_PRM5_USU=this.AV9PRM5_USU;
         aP1_PRM5_ZNA=this.AV8PRM5_ZNA;
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
         /*
            INSERT RECORD ON TABLE TPRM005

         */
         A284PRM5_USU = AV9PRM5_USU ;
         A285PRM5_ZNA = AV8PRM5_ZNA ;
         /* Using cursor P002I2 */
         pr_default.execute(0, new Object[] {A284PRM5_USU, A285PRM5_ZNA});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG102_2");
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
         A284PRM5_USU = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg102_2__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV8PRM5_ZNA ;
      private int GX_INS20 ;
      private int A285PRM5_ZNA ;
      private String AV9PRM5_USU ;
      private String A284PRM5_USU ;
      private String Gx_emsg ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_PRM5_USU ;
      private int aP1_PRM5_ZNA ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg102_2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002I2 ;
          prmP002I2 = new Object[] {
          new Object[] {"@PRM5_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@PRM5_ZNA",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002I2", "INSERT INTO [TPRM005] ([PRM5_USU], [PRM5_ZNA]) VALUES (@PRM5_USU, @PRM5_ZNA)", GxErrorMask.GX_NOMASK,prmP002I2)
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
