/*
               File: AppMasterPage
        Description: Application Master Page
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:36.21
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
   public class appmasterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public appmasterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public appmasterpage( IGxContext context )
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
         chkavIsauthorized = new GXCheckbox();
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
            PA012( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               chkavIsauthorized.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, chkavIsauthorized_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsauthorized.Enabled), 5, 0)));
               WS012( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE012( ) ;
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

      protected void RenderHtmlCloseForm012( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vFISHEYEDATA_MPAGE", (Object)(AV7FisheyeData));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vFISHEYEDATA_MPAGE", (Object)(AV7FisheyeData));
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vSMOOTHNAVMENUDATA_MPAGE", (Object)(AV24SmoothNavMenuData));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSMOOTHNAVMENUDATA_MPAGE", (Object)(AV24SmoothNavMenuData));
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vSMOOTHNAVMENUSELECTEDITEM_MPAGE", (Object)(AV25SmoothNavMenuSelectedItem));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSMOOTHNAVMENUSELECTEDITEM_MPAGE", (Object)(AV25SmoothNavMenuSelectedItem));
         }
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Width", StringUtil.LTrim( StringUtil.NToC( (decimal)(Fisheye1_Width), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Height", StringUtil.LTrim( StringUtil.NToC( (decimal)(Fisheye1_Height), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Maxwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(Fisheye1_Maxwidth), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Maxheight", StringUtil.LTrim( StringUtil.NToC( (decimal)(Fisheye1_Maxheight), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Attachedge", StringUtil.RTrim( Fisheye1_Attachedge));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Labeledge", StringUtil.RTrim( Fisheye1_Labeledge));
         GxWebStd.gx_hidden_field( context, "FISHEYE1_MPAGE_Visible", StringUtil.BoolToStr( Fisheye1_Visible));
         GxWebStd.gx_hidden_field( context, "SMOOTHNAVMENU1_MPAGE_Normalbackground", StringUtil.LTrim( StringUtil.NToC( (decimal)(Smoothnavmenu1_Normalbackground), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SMOOTHNAVMENU1_MPAGE_Hoverbackground", StringUtil.LTrim( StringUtil.NToC( (decimal)(Smoothnavmenu1_Hoverbackground), 9, 0, ".", "")));
         getDataAreaObject().RenderHtmlCloseForm();
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            WebComp_Wcrecentlinks.componentjscripts();
         }
         context.AddJavascriptSource("Shared/jquery/jquery-1.4.2.min.js", "");
         context.AddJavascriptSource("Fisheye/static/dojo.js", "");
         context.AddJavascriptSource("Fisheye/reference.js", "");
         context.AddJavascriptSource("Fisheye/FisheyeRender.js", "");
         context.AddJavascriptSource("SmoothNavMenu/resources/ddsmoothmenu.js", "");
         context.AddJavascriptSource("SmoothNavMenu/SmoothNavMenuRender.js", "");
         context.AddJavascriptSource("appmasterpage.js", "?11173628");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB010( )
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
            wb_table1_3_012( true) ;
         }
         else
         {
            wb_table1_3_012( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START012( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWcrecentlinks = cgiGet( "MPW0037") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcrecentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcrecentlinks)) )
            {
               WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
               WebComp_Wcrecentlinks.ComponentInit();
               WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
               WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
               WebComp_Wcrecentlinks.componentrestorestate("MPW0037", "");
            }
         }
         wbErr = false ;
         STRUP010( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
         }
      }

      protected void WS012( )
      {
         START012( ) ;
         EVT012( ) ;
      }

      protected void EVT012( )
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
                        else if ( StringUtil.StrCmp(sEvt, "FISHEYE1_MPAGE.ONCLICK_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11012 */
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SMOOTHNAVMENU1_MPAGE.ONCLICK_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12012 */
                           E12012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E13012 */
                           E13012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14012 */
                           E14012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DESCONECTAR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E15012 */
                           E15012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E16012 */
                           E16012 ();
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
                  else if ( StringUtil.StrCmp(sEvtType, "M") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-2)) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-6)) ;
                     nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                     if ( nCmpId == 37 )
                     {
                        OldWcrecentlinks = cgiGet( "MPW0037") ;
                        if ( ( StringUtil.Len( OldWcrecentlinks) == 0 ) || ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 ) )
                        {
                           WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
                           WebComp_Wcrecentlinks.ComponentInit();
                           WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
                           WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
                        }
                        if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
                        {
                           WebComp_Wcrecentlinks.componentprocess("MPW0037", "", sEvt);
                        }
                        WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
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

      protected void WE012( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm012( ) ;
            }
         }
      }

      protected void PA012( )
      {
         if ( nDonePA == 0 )
         {
            chkavIsauthorized.Name = "vISAUTHORIZED_MPAGE" ;
            chkavIsauthorized.WebTags = "" ;
            chkavIsauthorized.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, chkavIsauthorized_Internalname, "Caption", chkavIsauthorized.Caption);
            chkavIsauthorized.CheckedValue = "false" ;
            GX_FocusControl = chkavIsauthorized_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF012( ) ;
         /* End function Refresh */
      }

      protected void RF012( )
      {
         /* Execute user event: E14012 */
         E14012 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( WebComp_Wcrecentlinks_Visible != 0 )
            {
               if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
               {
                  WebComp_Wcrecentlinks.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E16012 */
            E16012 ();
            WB010( ) ;
         }
      }

      protected void STRUP010( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         chkavIsauthorized.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, chkavIsauthorized_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsauthorized.Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E13012 */
         E13012 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vFISHEYEDATA_MPAGE"), (Object)(AV7FisheyeData));
            ajax_req_read_hidden_sdt(cgiGet( "vSMOOTHNAVMENUDATA_MPAGE"), (Object)(AV24SmoothNavMenuData));
            ajax_req_read_hidden_sdt(cgiGet( "vSMOOTHNAVMENUSELECTEDITEM_MPAGE"), (Object)(AV25SmoothNavMenuSelectedItem));
            /* Read variables values. */
            AV11IsAuthorized = StringUtil.StrToBool( cgiGet( chkavIsauthorized_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV11IsAuthorized", StringUtil.BoolToStr( AV11IsAuthorized));
            /* Read saved values. */
            OldWcrecentlinks = cgiGet( "MPW0037") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcrecentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcrecentlinks)) )
            {
               WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
               WebComp_Wcrecentlinks.ComponentInit();
               WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
               WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
               WebComp_Wcrecentlinks.componentrestorestate("MPW0037", "");
            }
            Fisheye1_Width = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Width"), ",", ".")) ;
            Fisheye1_Height = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Height"), ",", ".")) ;
            Fisheye1_Orientation = cgiGet( "FISHEYE1_MPAGE_Orientation") ;
            Fisheye1_Maxwidth = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Maxwidth"), ",", ".")) ;
            Fisheye1_Maxheight = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Maxheight"), ",", ".")) ;
            Fisheye1_Effectunits = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Effectunits"), ",", ".")) ;
            Fisheye1_Itempadding = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Itempadding"), ",", ".")) ;
            Fisheye1_Attachedge = cgiGet( "FISHEYE1_MPAGE_Attachedge") ;
            Fisheye1_Labeledge = cgiGet( "FISHEYE1_MPAGE_Labeledge") ;
            Fisheye1_Selectedimageid = (int)(context.localUtil.CToN( cgiGet( "FISHEYE1_MPAGE_Selectedimageid"), ",", ".")) ;
            Fisheye1_Conservativetrigger = cgiGet( "FISHEYE1_MPAGE_Conservativetrigger") ;
            Fisheye1_Visible = StringUtil.StrToBool( cgiGet( "FISHEYE1_MPAGE_Visible")) ;
            Smoothnavmenu1_Width = cgiGet( "SMOOTHNAVMENU1_MPAGE_Width") ;
            Smoothnavmenu1_Height = cgiGet( "SMOOTHNAVMENU1_MPAGE_Height") ;
            Smoothnavmenu1_Orientation = cgiGet( "SMOOTHNAVMENU1_MPAGE_Orientation") ;
            Smoothnavmenu1_Normalbackground = (int)(context.localUtil.CToN( cgiGet( "SMOOTHNAVMENU1_MPAGE_Normalbackground"), ",", ".")) ;
            Smoothnavmenu1_Hoverbackground = (int)(context.localUtil.CToN( cgiGet( "SMOOTHNAVMENU1_MPAGE_Hoverbackground"), ",", ".")) ;
            Smoothnavmenu1_Visible = StringUtil.StrToBool( cgiGet( "SMOOTHNAVMENU1_MPAGE_Visible")) ;
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
         /* Execute user event: E13012 */
         E13012 ();
         if (returnInSub) return;
      }

      protected void E13012( )
      {
         /* Start Routine */
         WebComp_Wcrecentlinks_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
         new loadcontext(context ).execute( out  AV6Context) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV6Context.gxTpr_User)) )
         {
            imgImage3_Bitmap = "./Fisheye/images/PREGUNTA.PNG" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgImage3_Internalname, "Bitmap", context.convertURL( imgImage3_Bitmap));
            /* Window Datatype Object Property */
            AV20WindowSeg.Url = formatLink("wcseguridad.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5PRG_WEB)) ;
            AV20WindowSeg.SetReturnParms(new Object[] {"AV5PRG_WEB"});
            context.NewWindow(AV20WindowSeg);
            new loadcontext(context ).execute( out  AV6Context) ;
            context.DoAjaxRefresh();
         }
         AV26SERVER = "localhost/MarianoTesis.NetEnvironment" ;
         if ( ! (0==AV6Context.gxTpr_Sistema) )
         {
            new isauthorizedx(context ).execute(  AV6Context.gxTpr_Sistema,  Contentholder.Pgmname, out  AV11IsAuthorized) ;
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV11IsAuthorized", StringUtil.BoolToStr( AV11IsAuthorized));
            if ( ! AV11IsAuthorized )
            {
               /* Window Datatype Object Property */
               AV20WindowSeg.Url = formatLink("wcseguridad.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5PRG_WEB)) ;
               AV20WindowSeg.SetReturnParms(new Object[] {"AV5PRG_WEB"});
               context.NewWindow(AV20WindowSeg);
               new loadcontext(context ).execute( out  AV6Context) ;
               new isauthorizedx(context ).execute(  AV6Context.gxTpr_Sistema,  Contentholder.Pgmname, out  AV11IsAuthorized) ;
               context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV11IsAuthorized", StringUtil.BoolToStr( AV11IsAuthorized));
               Fisheye1_Visible = Convert.ToBoolean( 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, Fisheye1_Internalname, "Visible", StringUtil.BoolToStr( Fisheye1_Visible));
               WebComp_Wcrecentlinks_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
               tblTablecontent_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            }
            else
            {
               Fisheye1_Visible = Convert.ToBoolean( 1) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, Fisheye1_Internalname, "Visible", StringUtil.BoolToStr( Fisheye1_Visible));
               WebComp_Wcrecentlinks_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
               tblTablecontent_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            }
            if ( StringUtil.StrCmp(AV6Context.gxTpr_User, "") != 0 )
            {
               Fisheye1_Visible = Convert.ToBoolean( 1) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, Fisheye1_Internalname, "Visible", StringUtil.BoolToStr( Fisheye1_Visible));
               WebComp_Wcrecentlinks_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
               tblTablecontent_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            }
            else
            {
               Fisheye1_Visible = Convert.ToBoolean( 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, Fisheye1_Internalname, "Visible", StringUtil.BoolToStr( Fisheye1_Visible));
               WebComp_Wcrecentlinks_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
               tblTablecontent_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            }
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
         lblTxtusuario_Caption = AV6Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblTxtusuario_Internalname, "Caption", lblTxtusuario_Caption);
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         AV13LOG_PRG = Contentholder.Pgmname ;
         AV12LOG_PRD = Contentholder.Pgmdesc ;
         AV16LOG_WST = GXUtil.WrkSt( context) ;
         AV15LOG_SYS = StringUtil.Str( (decimal)(AV6Context.gxTpr_Sistema), 4, 0) ;
         lblTxtprograma_Caption = Contentholder.Pgmdesc ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblTxtprograma_Internalname, "Caption", lblTxtprograma_Caption);
      }

      protected void E14012( )
      {
         /* Refresh Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Wcrecentlinks_Component, "RecentLinks") != 0 )
         {
            WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", "recentlinks", new Object[] {context} );
            WebComp_Wcrecentlinks.ComponentInit();
            WebComp_Wcrecentlinks.Name = "RecentLinks";
            WebComp_Wcrecentlinks_Component = "RecentLinks" ;
         }
         if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
         {
            WebComp_Wcrecentlinks.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
         {
            WebComp_Wcrecentlinks.componentprepare(new Object[] {(String)"MPW0037",(String)"",getDataAreaObject().GetForm().Caption,Contentholder.Pgmname});
            WebComp_Wcrecentlinks.componentbind(new Object[] {(String)"",(String)""});
         }
         new loadcontext(context ).execute( out  AV6Context) ;
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
         AV10IMAGEN = AV6Context.gxTpr_Icono ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10IMAGEN)) )
         {
            imgImage3_Bitmap = "./Fisheye/images/PREGUNTA.PNG" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgImage3_Internalname, "Bitmap", context.convertURL( imgImage3_Bitmap));
         }
         else
         {
            imgImage3_Bitmap = AV10IMAGEN ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgImage3_Internalname, "Bitmap", context.convertURL( imgImage3_Bitmap));
         }
      }

      protected void E11012( )
      {
         /* Fisheye1_Onclick Routine */
         AV9fisheyeIndex = (short)(Fisheye1_Selectedimageid) ;
         /* Using cursor H00012 */
         pr_default.execute(0, new Object[] {((SdtFisheyeData_FisheyeDataItem)AV7FisheyeData.Item(AV9fisheyeIndex)).gxTpr_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A116SIS_COD = H00012_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A123SIS_ICO = H00012_A123SIS_ICO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "A123SIS_ICO", A123SIS_ICO);
            AV10IMAGEN = "./Fisheye/images/" + StringUtil.Trim( A123SIS_ICO) ;
            imgImage3_Bitmap = AV10IMAGEN ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgImage3_Internalname, "Bitmap", context.convertURL( imgImage3_Bitmap));
            AV6Context.gxTpr_Icono = AV10IMAGEN ;
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
            AV6Context.gxTpr_Sistema = (short)(NumberUtil.Val( ((SdtFisheyeData_FisheyeDataItem)AV7FisheyeData.Item(AV9fisheyeIndex)).gxTpr_Id, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
            new setcontext(context ).execute(  AV6Context) ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         context.wjLoc = formatLink("homeintranet.aspx")  ;
      }

      protected void E15012( )
      {
         /* 'Desconectar' Routine */
         AV6Context.gxTpr_User = "" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         AV6Context.gxTpr_Sistema = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         new setcontext(context ).execute(  AV6Context) ;
         context.wjLoc = formatLink("homeintranet.aspx")  ;
      }

      protected void E12012( )
      {
         /* Smoothnavmenu1_Onclick Routine */
         new loadcontext(context ).execute( out  AV6Context) ;
         AV6Context.gxTpr_Programa = (short)(NumberUtil.Val( AV25SmoothNavMenuSelectedItem.gxTpr_Id, ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         new setcontext(context ).execute(  AV6Context) ;
      }

      protected void S122( )
      {
         /* 'SMOOTHNAVMENU' Routine */
         new loadcontext(context ).execute( out  AV6Context) ;
         AV21PRS_NRO = AV6Context.gxTpr_Sesion ;
         GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 = AV24SmoothNavMenuData ;
         new smoothnavmenudatamp(context ).execute(  AV6Context.gxTpr_User,  AV6Context.gxTpr_Sistema,  AV21PRS_NRO,  AV26SERVER, out  GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         AV24SmoothNavMenuData = GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 ;
      }

      protected void S112( )
      {
         /* 'FISHEYESAMPLE' Routine */
         new loadcontext(context ).execute( out  AV6Context) ;
         GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 = (IGxCollection)(AV7FisheyeData) ;
         GXt_objcol_SdtFisheyeData_FisheyeDataItem3 = (IGxCollection)(GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2) ;
         new fisheyedatamenu(context ).execute(  AV6Context.gxTpr_User, out  GXt_objcol_SdtFisheyeData_FisheyeDataItem3) ;
         GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 = GXt_objcol_SdtFisheyeData_FisheyeDataItem3 ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         AV7FisheyeData = GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 ;
      }

      protected void nextLoad( )
      {
      }

      protected void E16012( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0xFFFFFF)) + ";" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table95", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr bgcolor=\"#4682B4\" >") ;
            context.WriteHtmlText( "<td bgcolor=\"#4682B4\" bordercolor=\"#4682B4\"  style=\"height:0px\">") ;
            wb_table2_6_012( true) ;
         }
         else
         {
            wb_table2_6_012( false) ;
         }
         return  ;
      }

      protected void wb_table2_6_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td bgcolor=\"#4682B4\" colspan=\"3\"  style=\"height:2px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table3_31_012( true) ;
         }
         else
         {
            wb_table3_31_012( false) ;
         }
         return  ;
      }

      protected void wb_table3_31_012e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "Title" ;
            StyleString = "font-family:'Verdana'; font-size:11.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTxtprograma_Internalname, 1, 1, 0, lblTxtprograma_Caption, "", "", "", 0, lblTxtprograma_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table4_41_012( true) ;
         }
         else
         {
            wb_table4_41_012( false) ;
         }
         return  ;
      }

      protected void wb_table4_41_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:18px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "<hr/>") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage2_Internalname, "", context.GetImagePath( "f5f8a0c4-001a-440a-877e-a7d6e67aefb3", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 175, "", 68, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_012e( true) ;
         }
         else
         {
            wb_table1_3_012e( false) ;
         }
      }

      protected void wb_table4_41_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_44_012( true) ;
         }
         else
         {
            wb_table5_44_012( false) ;
         }
         return  ;
      }

      protected void wb_table5_44_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_41_012e( true) ;
         }
         else
         {
            wb_table4_41_012e( false) ;
         }
      }

      protected void wb_table5_44_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTablecontent_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTablecontent_Internalname, tblTablecontent_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            getDataAreaObject().RenderHtmlContent();
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_44_012e( true) ;
         }
         else
         {
            wb_table5_44_012e( false) ;
         }
      }

      protected void wb_table3_31_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage3_Internalname, "", imgImage3_Bitmap, "Modern", 1, 1, "", "", 0, 0, 0, "", 40, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"width:100%\">") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"MPSMOOTHNAVMENU1Container"+"\"></div>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "MPW0037"+"", StringUtil.RTrim( WebComp_Wcrecentlinks_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0037"+""+"\""+((WebComp_Wcrecentlinks_Visible==1) ? "" : " style=\"display:none;\"")) ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0037"+"");
               }
               WebComp_Wcrecentlinks.componentdraw();
               if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_31_012e( true) ;
         }
         else
         {
            wb_table3_31_012e( false) ;
         }
      }

      protected void wb_table2_6_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0xFFFFFF)) + ";" ;
            if ( StringUtil.StrCmp(context.BuildHTMLColor( (int)(0xFFFFFF))+";", "") != 0 )
            {
               sStyleString = sStyleString + " border-color: " + context.BuildHTMLColor( (int)(0xFFFFFF)) + ";" ;
            }
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "TableTop", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr bgcolor=\"#FFFFFF\" >") ;
            context.WriteHtmlText( "<td bgcolor=\"#FFFFFF\"  style=\"height:25px;width:242px\">") ;
            wb_table6_9_012( true) ;
         }
         else
         {
            wb_table6_9_012( false) ;
         }
         return  ;
      }

      protected void wb_table6_9_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td bgcolor=\"#FFFFFF\" bordercolor=\"#FFFFFF\"  style=\"text-align:"+context.GetCssProperty( "Align", "left")+";width:501px\">") ;
            context.WriteHtmlText( "<div style=\"WIDTH: 500px\" class=\"Section\" id=\"Section1\">") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"MPFISHEYE1Container"+"\"></div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class=\"td10px\" bgcolor=\"#FFFFFF\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";width:312px\">") ;
            wb_table7_21_012( true) ;
         }
         else
         {
            wb_table7_21_012( false) ;
         }
         return  ;
      }

      protected void wb_table7_21_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_6_012e( true) ;
         }
         else
         {
            wb_table2_6_012e( false) ;
         }
      }

      protected void wb_table7_21_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',true,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton1_Internalname, "Cambiar Contraseña", "Cambiar Contraseña", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton1_Jsonclick, "'"+""+"'"+",true,"+"'"+"e17012_client"+"'", TempTags, "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_21_012e( true) ;
         }
         else
         {
            wb_table7_21_012e( false) ;
         }
      }

      protected void wb_table6_9_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(240), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:104px\">") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "1382f836-ea82-4658-aa27-5d13e1b4b3fb", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 249, "", 116, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:24px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#4682B4" ;
            GxWebStd.gx_label_ctrl( context, lblTxtusuario_Internalname, 1, 1, 0, lblTxtusuario_Caption, "", "", "", 0, lblTxtusuario_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_AppMasterPage.htm");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',true,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavIsauthorized_Internalname, StringUtil.BoolToStr( AV11IsAuthorized), "", 1, chkavIsauthorized.Enabled, "true", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(16, this, 'true', 'false');gx.evt.onchange(this);\" "+" onblur=\""+""+";gx.evt.onblur(16);\"");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',true,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage4_Internalname, "", context.GetImagePath( "aa1ab5fc-b1c8-4d23-9ba5-98ca435ab24c", "", "Modern"), "Modern", 1, 1, "Desconectar", "", 0, 0, 0, "", 18, "", 0, 0, "", "", 5, imgImage4_Jsonclick, "EDESCONECTAR_MPAGE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_9_012e( true) ;
         }
         else
         {
            wb_table6_9_012e( false) ;
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
         PA012( ) ;
         WS012( ) ;
         WE012( ) ;
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
         AddStyleSheetFile("SmoothNavMenu/resources/ddsmoothmenu.css", "?2247100");
         AddStyleSheetFile("SmoothNavMenu/resources/ddsmoothmenu-v.css", "?2349340");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
            {
               WebComp_Wcrecentlinks.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= getDataAreaObject().GetForm().Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( getDataAreaObject().GetForm().Jscriptsrc.Item(idxLst)), "?11173672");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("appmasterpage.js", "?11173673");
         context.AddJavascriptSource("Shared/jquery/jquery-1.4.2.min.js", "");
         context.AddJavascriptSource("Fisheye/static/dojo.js", "");
         context.AddJavascriptSource("Fisheye/reference.js", "");
         context.AddJavascriptSource("Fisheye/FisheyeRender.js", "");
         context.AddJavascriptSource("SmoothNavMenu/resources/ddsmoothmenu.js", "");
         context.AddJavascriptSource("SmoothNavMenu/SmoothNavMenuRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgImage1_Internalname = "IMAGE1_MPAGE" ;
         lblTxtusuario_Internalname = "TXTUSUARIO_MPAGE" ;
         chkavIsauthorized_Internalname = "vISAUTHORIZED_MPAGE" ;
         imgImage4_Internalname = "IMAGE4_MPAGE" ;
         tblTable3_Internalname = "TABLE3_MPAGE" ;
         Fisheye1_Internalname = "FISHEYE1_MPAGE" ;
         bttButton1_Internalname = "BUTTON1_MPAGE" ;
         tblTable6_Internalname = "TABLE6_MPAGE" ;
         tblTable1_Internalname = "TABLE1_MPAGE" ;
         imgImage3_Internalname = "IMAGE3_MPAGE" ;
         Smoothnavmenu1_Internalname = "SMOOTHNAVMENU1_MPAGE" ;
         tblTable2_Internalname = "TABLE2_MPAGE" ;
         lblTxtprograma_Internalname = "TXTPROGRAMA_MPAGE" ;
         tblTablecontent_Internalname = "TABLECONTENT_MPAGE" ;
         tblTable5_Internalname = "TABLE5_MPAGE" ;
         imgImage2_Internalname = "IMAGE2_MPAGE" ;
         tblTable4_Internalname = "TABLE4_MPAGE" ;
         getDataAreaObject().GetForm().Internalname = "FORM_MPAGE" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         chkavIsauthorized.Enabled = 1 ;
         imgImage3_Bitmap = "(none)" ;
         Fisheye1_Selectedimageid = 0 ;
         lblTxtprograma_Caption = "Titulo" ;
         lblTxtusuario_Caption = "USUARIO" ;
         tblTablecontent_Visible = 1 ;
         WebComp_Wcrecentlinks_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0037"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcrecentlinks_Visible), 5, 0)));
         chkavIsauthorized.Caption = "" ;
         Smoothnavmenu1_Hoverbackground = (int)(0x2F4F4F) ;
         Smoothnavmenu1_Normalbackground = (int)(0x4682B4) ;
         Fisheye1_Visible = Convert.ToBoolean( -1) ;
         Fisheye1_Labeledge = "center" ;
         Fisheye1_Attachedge = "top" ;
         Fisheye1_Maxheight = 120 ;
         Fisheye1_Maxwidth = 90 ;
         Fisheye1_Height = 40 ;
         Fisheye1_Width = 30 ;
         Contentholder.setDataArea(getDataAreaObject());
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
         Contentholder = new GXDataAreaControl();
         AV7FisheyeData = new GxObjectCollection( context, "FisheyeData.FisheyeDataItem", "MarianoTesis", "SdtFisheyeData_FisheyeDataItem", "GeneXus.Programs");
         AV24SmoothNavMenuData = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs");
         AV25SmoothNavMenuSelectedItem = new SdtSmoothNavMenuData_SmoothNavMenuItem(context);
         sPrefix = "" ;
         OldWcrecentlinks = "" ;
         WebComp_Wcrecentlinks_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_FocusControl = "" ;
         Fisheye1_Orientation = "" ;
         Fisheye1_Conservativetrigger = "" ;
         Smoothnavmenu1_Width = "" ;
         Smoothnavmenu1_Height = "" ;
         Smoothnavmenu1_Orientation = "" ;
         AV6Context = new SdtContext(context);
         AV5PRG_WEB = "" ;
         AV20WindowSeg = new GXWindow();
         AV26SERVER = "" ;
         AV13LOG_PRG = "" ;
         AV12LOG_PRD = "" ;
         AV16LOG_WST = "" ;
         AV15LOG_SYS = "" ;
         AV10IMAGEN = "" ;
         scmdbuf = "" ;
         H00012_A116SIS_COD = new short[1] ;
         H00012_A123SIS_ICO = new String[] {""} ;
         A123SIS_ICO = "" ;
         GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs");
         GXt_objcol_SdtFisheyeData_FisheyeDataItem3 = new GxObjectCollection( context, "FisheyeData.FisheyeDataItem", "MarianoTesis", "SdtFisheyeData_FisheyeDataItem", "GeneXus.Programs");
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTxtprograma_Jsonclick = "" ;
         GXt_char4 = "" ;
         GXt_char1 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTxtusuario_Jsonclick = "" ;
         imgImage4_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "" ;
         Form = new GXWebForm();
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.appmasterpage__default(),
            new Object[][] {
                new Object[] {
               H00012_A116SIS_COD, H00012_A123SIS_ICO
               }
            }
         );
         WebComp_Wcrecentlinks = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         chkavIsauthorized.Enabled = 0 ;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV9fisheyeIndex ;
      private short A116SIS_COD ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int Fisheye1_Width ;
      private int Fisheye1_Height ;
      private int Fisheye1_Maxwidth ;
      private int Fisheye1_Maxheight ;
      private int Smoothnavmenu1_Normalbackground ;
      private int Smoothnavmenu1_Hoverbackground ;
      private int WebComp_Wcrecentlinks_Visible ;
      private int Fisheye1_Effectunits ;
      private int Fisheye1_Itempadding ;
      private int Fisheye1_Selectedimageid ;
      private int tblTablecontent_Visible ;
      private int AV21PRS_NRO ;
      private int idxLst ;
      private String chkavIsauthorized_Internalname ;
      private String Fisheye1_Attachedge ;
      private String Fisheye1_Labeledge ;
      private String sPrefix ;
      private String OldWcrecentlinks ;
      private String WebComp_Wcrecentlinks_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GX_FocusControl ;
      private String Fisheye1_Orientation ;
      private String Fisheye1_Conservativetrigger ;
      private String Smoothnavmenu1_Width ;
      private String Smoothnavmenu1_Height ;
      private String Smoothnavmenu1_Orientation ;
      private String imgImage3_Internalname ;
      private String AV5PRG_WEB ;
      private String AV26SERVER ;
      private String Fisheye1_Internalname ;
      private String tblTablecontent_Internalname ;
      private String lblTxtusuario_Caption ;
      private String lblTxtusuario_Internalname ;
      private String AV13LOG_PRG ;
      private String AV12LOG_PRD ;
      private String AV16LOG_WST ;
      private String AV15LOG_SYS ;
      private String lblTxtprograma_Caption ;
      private String lblTxtprograma_Internalname ;
      private String scmdbuf ;
      private String A123SIS_ICO ;
      private String sStyleString ;
      private String tblTable4_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTxtprograma_Jsonclick ;
      private String imgImage2_Internalname ;
      private String tblTable5_Internalname ;
      private String tblTable2_Internalname ;
      private String tblTable1_Internalname ;
      private String GXt_char4 ;
      private String GXt_char1 ;
      private String tblTable6_Internalname ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable3_Internalname ;
      private String imgImage1_Internalname ;
      private String lblTxtusuario_Jsonclick ;
      private String imgImage4_Internalname ;
      private String imgImage4_Jsonclick ;
      private String sDynURL ;
      private String Smoothnavmenu1_Internalname ;
      private String GXt_char5 ;
      private bool Fisheye1_Visible ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool AV11IsAuthorized ;
      private bool Smoothnavmenu1_Visible ;
      private bool returnInSub ;
      private String AV10IMAGEN ;
      private String imgImage3_Bitmap ;
      private GXWebComponent WebComp_Wcrecentlinks ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavIsauthorized ;
      private GXDataAreaControl Contentholder ;
      private IDataStoreProvider pr_default ;
      private short[] H00012_A116SIS_COD ;
      private String[] H00012_A123SIS_ICO ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtFisheyeData_FisheyeDataItem ))]
      private IGxCollection AV7FisheyeData ;
      [ObjectCollection(ItemType=typeof( SdtFisheyeData_FisheyeDataItem ))]
      private IGxCollection GXt_objcol_SdtFisheyeData_FisheyeDataItem3 ;
      [ObjectCollection(ItemType=typeof( SdtSmoothNavMenuData_SmoothNavMenuItem ))]
      private IGxCollection AV24SmoothNavMenuData ;
      [ObjectCollection(ItemType=typeof( SdtSmoothNavMenuData_SmoothNavMenuItem ))]
      private IGxCollection GXt_objcol_SdtSmoothNavMenuData_SmoothNavMenuItem2 ;
      private GXWebForm Form ;
      private GXWindow AV20WindowSeg ;
      private SdtContext AV6Context ;
      private SdtSmoothNavMenuData_SmoothNavMenuItem AV25SmoothNavMenuSelectedItem ;
   }

   public class appmasterpage__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00012 ;
          prmH00012 = new Object[] {
          new Object[] {"@SdtFisItemAV9fisheyeIndex",SqlDbType.Char,500,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00012", "SELECT [SIS_COD], [SIS_ICO] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = CONVERT( DECIMAL(28,14), @SdtFisItemAV9fisheyeIndex) ORDER BY [SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00012,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
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
       }
    }

 }

}
