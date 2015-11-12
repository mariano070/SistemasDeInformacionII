/*
               File: HMASTER_INTRANET
        Description: MASTER_ INTRANET
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:21.70
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hmaster_intranet : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public hmaster_intranet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hmaster_intranet( IGxContext context )
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
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            PA382( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV12Pgmdesc = "MASTER_ INTRANET" ;
               context.Gx_err = 0 ;
               WS382( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE382( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         getDataAreaObject().RenderHtmlHeaders();
      }

      protected void RenderHtmlOpenForm( )
      {
         getDataAreaObject().RenderHtmlOpenForm();
      }

      protected void RenderHtmlCloseForm382( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         getDataAreaObject().RenderHtmlCloseForm();
         context.AddJavascriptSource("hmaster_intranet.js", "?11182171");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB380( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               getDataAreaObject().RenderHtmlContent();
               return  ;
            }
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_382( true) ;
         }
         else
         {
            wb_table1_3_382( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_382e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START382( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP380( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
         }
      }

      protected void WS382( )
      {
         START382( ) ;
         EVT382( ) ;
      }

      protected void EVT382( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11382 */
                           E11382 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12382 */
                           E12382 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false ;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void WE382( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm382( ) ;
            }
         }
      }

      protected void PA382( )
      {
         if ( nDonePA == 0 )
         {
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF382( ) ;
         /* End function Refresh */
      }

      protected void RF382( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E12382 */
            E12382 ();
            WB380( ) ;
         }
      }

      protected void STRUP380( )
      {
         /* Before Start, stand alone formulas. */
         AV12Pgmdesc = "MASTER_ INTRANET" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11382 */
         E11382 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E11382 */
         E11382 ();
         if (returnInSub) return;
      }

      protected void E11382( )
      {
         /* Start Routine */
         AV5LOG_PRG = Contholder1.Pgmname ;
         AV6LOG_PRD = Contholder1.Pgmdesc ;
         AV7USUARIO = context.GetCookie( "USUARIO") ;
         AV8LOG_WST = GXUtil.WrkSt( context) ;
         GXt_char1 = " " ;
         GXt_int2 = 0 ;
         new plog000(context ).execute( ref  AV12Pgmdesc, ref  AV5LOG_PRG, ref  AV6LOG_PRD, ref  AV7USUARIO, ref  AV8LOG_WST, ref  GXt_char1, ref  GXt_int2) ;
         lblDesc_programa_Caption = Contholder1.Pgmdesc ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblDesc_programa_Internalname, "Caption", lblDesc_programa_Caption);
      }

      protected void nextLoad( )
      {
      }

      protected void E12382( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_382( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td background=\"\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:50px;width:780px\">") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "b4a87bdc-f323-4980-9bdf-84b00ef343a9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_HMASTER_INTRANET.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            /* Text block */
            ClassString = "menu" ;
            StyleString = "font-family:'Verdana'; font-size:10.0pt; font-weight:bold; font-style:normal; color:#008080" ;
            GxWebStd.gx_label_ctrl( context, lblDesc_programa_Internalname, 1, 1, 0, lblDesc_programa_Caption, "", "", "", 0, lblDesc_programa_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_HMASTER_INTRANET.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            getDataAreaObject().RenderHtmlContent();
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_382e( true) ;
         }
         else
         {
            wb_table1_3_382e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA382( ) ;
         WS382( ) ;
         WE382( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= getDataAreaObject().GetForm().Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( getDataAreaObject().GetForm().Jscriptsrc.Item(idxLst)), "?11182176");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("hmaster_intranet.js", "?11182176");
         }
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgImage1_Internalname = "IMAGE1_MPAGE" ;
         lblDesc_programa_Internalname = "DESC_PROGRAMA_MPAGE" ;
         tblTable1_Internalname = "TABLE1_MPAGE" ;
         getDataAreaObject().GetForm().Internalname = "FORM_MPAGE" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         lblDesc_programa_Caption = " " ;
         Contholder1.setDataArea(getDataAreaObject());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Contholder1 = new GXDataAreaControl();
         AV12Pgmdesc = "" ;
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV5LOG_PRG = "" ;
         AV6LOG_PRD = "" ;
         AV7USUARIO = "" ;
         AV8LOG_WST = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblDesc_programa_Jsonclick = "" ;
         GXt_char1 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "" ;
         Form = new GXWebForm();
         AV12Pgmdesc = "MASTER_ INTRANET" ;
         /* GeneXus formulas. */
         AV12Pgmdesc = "MASTER_ INTRANET" ;
         context.Gx_err = 0 ;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int GXt_int2 ;
      private int idxLst ;
      private String AV12Pgmdesc ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV5LOG_PRG ;
      private String AV6LOG_PRD ;
      private String AV7USUARIO ;
      private String AV8LOG_WST ;
      private String lblDesc_programa_Caption ;
      private String lblDesc_programa_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String lblDesc_programa_Jsonclick ;
      private String GXt_char1 ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contholder1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
