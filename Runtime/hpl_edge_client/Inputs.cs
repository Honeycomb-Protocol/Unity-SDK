using Newtonsoft.Json;
using System.Collections.Generic;

using HplEdgeClient.Enums;

namespace HplEdgeClient.Inputs
{
  public class CharacterTraitInput
  {
    [JsonProperty("label")]
    public string Label;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("uri")]
    public string Uri;

    public CharacterTraitInput() { }

  }

  public class MintAsInput
  {
    [JsonProperty("kind")]
    public MintAsKind Kind;

    [JsonProperty("mplBubblegum")]
    public MintAsMplBubblegumInput MplBubblegum;

    public MintAsInput() { }

  }

  public class MintAsMplBubblegumInput
  {
    [JsonProperty("maxDepth")]
    public int MaxDepth;

    [JsonProperty("maxBufferSize")]
    public int MaxBufferSize;

    public MintAsMplBubblegumInput() { }

  }

  public class CharacterConfigInput
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("criterias")]
    public List<AssetCriteriaInput> Criterias;

    [JsonProperty("assemblerConfigInput")]
    public AssemblerConfigInput AssemblerConfigInput;

    public CharacterConfigInput() { }

  }

  public class AssemblerConfigInput
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("symbol")]
    public string Symbol;

    [JsonProperty("description")]
    public string Description;

    [JsonProperty("creators")]
    public List<NftCreatorInput> Creators;

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints;

    [JsonProperty("collectionName")]
    public string CollectionName;

    public AssemblerConfigInput() { }

  }

  public class NftCreatorInput
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("share")]
    public int Share;

    public NftCreatorInput() { }

  }

  public class AssetCriteriaInput
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public string Params;

    public AssetCriteriaInput() { }

  }

  public class CharactersFilter
  {
    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("source")]
    public CharacterSourceFilter Source;

    [JsonProperty("usedBy")]
    public CharacterUsedByFilter UsedBy;

    public CharactersFilter() { }

  }

  public class CharacterSourceFilter
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public CharacterSourceParamsFilter Params;

    public CharacterSourceFilter() { }

  }

  public class CharacterSourceParamsFilter
  {
    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("criteria")]
    public AssetCriteriaFilter Criteria;

    [JsonProperty("is_compressed")]
    public bool Is_compressed;

    public CharacterSourceParamsFilter() { }

  }

  public class AssetCriteriaFilter
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public string Params;

    public AssetCriteriaFilter() { }

  }

  public class CharacterUsedByFilter
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public CharacterUsedByParamsFilter Params;

    public CharacterUsedByFilter() { }

  }

  public class CharacterUsedByParamsFilter
  {
    [JsonProperty("pool")]
    public string Pool;

    [JsonProperty("staker")]
    public string Staker;

    [JsonProperty("stakedAt")]
    public int StakedAt;

    [JsonProperty("claimedAt")]
    public int ClaimedAt;

    [JsonProperty("id")]
    public string Id;

    [JsonProperty("rewards")]
    public List<EarnedRewardsFilter> Rewards;

    [JsonProperty("endTime")]
    public int EndTime;

    [JsonProperty("rewardsCollected")]
    public bool RewardsCollected;

    [JsonProperty("role")]
    public GuildRoleFilter Role;

    [JsonProperty("order")]
    public int Order;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("user")]
    public string User;

    public CharacterUsedByParamsFilter() { }

  }

  public class EarnedRewardsFilter
  {
    [JsonProperty("delta")]
    public int Delta;

    [JsonProperty("rewardIdx")]
    public int RewardIdx;

    public EarnedRewardsFilter() { }

  }

  public class UsedByGuildFilter
  {
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("role")]
    public GuildRoleFilter Role;

    [JsonProperty("order")]
    public int Order;

    public UsedByGuildFilter() { }

  }

  public class GuildRoleFilter
  {
    [JsonProperty("kind")]
    public string Kind;

    public GuildRoleFilter() { }

  }

  public class CivicInfoInput
  {
    [JsonProperty("gatekeeperNetwork")]
    public CivicGateway GatekeeperNetwork;

    [JsonProperty("wallet")]
    public string Wallet;

    public CivicInfoInput() { }

  }

  public class UserInfoInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("bio")]
    public string Bio;

    [JsonProperty("pfp")]
    public string Pfp;

    public UserInfoInput() { }

  }

  public class PartialUserInfoInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("bio")]
    public string Bio;

    [JsonProperty("pfp")]
    public string Pfp;

    public PartialUserInfoInput() { }

  }

  public class UpdateWalletInput
  {
    [JsonProperty("add")]
    public List<string> Add;

    [JsonProperty("remove")]
    public List<string> Remove;

    public UpdateWalletInput() { }

  }

  public class AssociatedProgramInput
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("trustedActions")]
    public List<SerializableActionsInput> TrustedActions;

    public AssociatedProgramInput() { }

  }

  public class SerializableActionsInput
  {
    [JsonProperty("kind")]
    public string Kind;

    public SerializableActionsInput() { }

  }

  public class ProfileDataConfigInput
  {
    [JsonProperty("achievements")]
    public List<string> Achievements;

    [JsonProperty("customDataFields")]
    public List<string> CustomDataFields;

    public ProfileDataConfigInput() { }

  }

  public class ProfileInfoInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("bio")]
    public string Bio;

    [JsonProperty("pfp")]
    public string Pfp;

    public ProfileInfoInput() { }

  }

  public class CustomDataInput
  {
    [JsonProperty("add")]
    public object Add;

    [JsonProperty("remove")]
    public List<string> Remove;

    public CustomDataInput() { }

  }

  public class ServiceDelegationInput
  {
    [JsonProperty("HiveControl")]
    public List<ServiceDelegationHiveControl> HiveControl;

    [JsonProperty("AssetAssembler")]
    public List<ServiceDelegationAssetAssembler> AssetAssembler;

    [JsonProperty("AssetManager")]
    public List<ServiceDelegationAssetManager> AssetManager;

    [JsonProperty("ResourceManager")]
    public List<ServiceDelegationResourceManager> ResourceManager;

    [JsonProperty("NectarStaking")]
    public List<ServiceDelegationNectarStaking> NectarStaking;

    [JsonProperty("NectarMissions")]
    public List<ServiceDelegationNectarMissions> NectarMissions;

    [JsonProperty("BuzzGuild")]
    public List<ServiceDelegationBuzzGuild> BuzzGuild;

    public ServiceDelegationInput() { }

  }

  public class ServiceDelegationHiveControl
  {
    [JsonProperty("permission")]
    public HiveControlPermissionInput Permission;

    public ServiceDelegationHiveControl() { }

  }

  public class ServiceDelegationAssetAssembler
  {
    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public AssetAssemblerPermissionInput Permission;

    public ServiceDelegationAssetAssembler() { }

  }

  public class ServiceDelegationAssetManager
  {
    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public AssetManagerPermissionInput Permission;

    public ServiceDelegationAssetManager() { }

  }

  public class ServiceDelegationResourceManager
  {
    [JsonProperty("permission")]
    public ResourceManagerPermissionInput Permission;

    public ServiceDelegationResourceManager() { }

  }

  public class ServiceDelegationNectarStaking
  {
    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public NectarStakingPermissionInput Permission;

    public ServiceDelegationNectarStaking() { }

  }

  public class ServiceDelegationNectarMissions
  {
    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public NectarMissionsPermissionInput Permission;

    public ServiceDelegationNectarMissions() { }

  }

  public class ServiceDelegationBuzzGuild
  {
    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public BuzzGuildPermissionInput Permission;

    public ServiceDelegationBuzzGuild() { }

  }

  public class ModifyServiceDelegationInput
  {
    [JsonProperty("HiveControl")]
    public ServiceDelegationHiveControl HiveControl;

    [JsonProperty("AssetAssembler")]
    public ServiceDelegationAssetAssembler AssetAssembler;

    [JsonProperty("AssetManager")]
    public ServiceDelegationAssetManager AssetManager;

    [JsonProperty("ResourceManager")]
    public ServiceDelegationResourceManager ResourceManager;

    [JsonProperty("NectarStaking")]
    public ServiceDelegationNectarStaking NectarStaking;

    [JsonProperty("NectarMissions")]
    public ServiceDelegationNectarMissions NectarMissions;

    [JsonProperty("BuzzGuild")]
    public ServiceDelegationBuzzGuild BuzzGuild;

    public ModifyServiceDelegationInput() { }

  }

  public class ModifyDelegationInput
  {
    [JsonProperty("delegation")]
    public ModifyServiceDelegationInput Delegation;

    [JsonProperty("index")]
    public int Index;

    public ModifyDelegationInput() { }

  }

  public class UpdateMissionInput
  {
    [JsonProperty("cost")]
    public NewMissionCost Cost;

    [JsonProperty("minXp")]
    public string MinXp;

    [JsonProperty("duration")]
    public string Duration;

    [JsonProperty("removeRewards")]
    public List<int> RemoveRewards;

    [JsonProperty("newRewards")]
    public List<MissionReward> NewRewards;

    [JsonProperty("updateRewards")]
    public List<MissionReward> UpdateRewards;

    public UpdateMissionInput() { }

  }

  public class CreateStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration;

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration;

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration;

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration;

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration;

    [JsonProperty("resetStakeDuration")]
    public bool ResetStakeDuration;

    [JsonProperty("startTime")]
    public string StartTime;

    [JsonProperty("lockType")]
    public LockTypeEnum LockType;

    [JsonProperty("endTime")]
    public string EndTime;

    public CreateStakingPoolMetadataInput() { }

  }

  public class UpdateStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration;

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration;

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration;

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration;

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration;

    [JsonProperty("resetStakeDuration")]
    public bool ResetStakeDuration;

    [JsonProperty("startTime")]
    public string StartTime;

    [JsonProperty("endTime")]
    public string EndTime;

    public UpdateStakingPoolMetadataInput() { }

  }

  public class MultiplierTypeInput
  {
    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration;

    [JsonProperty("minNftCount")]
    public string MinNftCount;

    [JsonProperty("creator")]
    public string Creator;

    [JsonProperty("collection")]
    public string Collection;

    public MultiplierTypeInput() { }

  }

  public class AddMultiplierMetadataInput
  {
    [JsonProperty("value")]
    public string Value;

    [JsonProperty("type")]
    public MultiplierTypeInput Type;

    public AddMultiplierMetadataInput() { }

  }

  public class InitStakingMultiplierMetadataInput
  {
    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("multipliers")]
    public List<AddMultiplierMetadataInput> Multipliers;

    public InitStakingMultiplierMetadataInput() { }

  }

  public class DisrcriminatorFilter
  {
    [JsonProperty("programId")]
    public string ProgramId;

    [JsonProperty("accountName")]
    public string AccountName;

    public DisrcriminatorFilter() { }

  }

  public class TreeLeaf
  {
    [JsonProperty("tree")]
    public string Tree;

    [JsonProperty("index")]
    public string Index;

    public TreeLeaf() { }

  }

  public class TreeSetupConfig
  {
    [JsonProperty("basic")]
    public BasicTreeConfig Basic;

    [JsonProperty("advanced")]
    public AdvancedTreeConfig Advanced;

    public TreeSetupConfig() { }

  }

  public class BasicTreeConfig
  {
    [JsonProperty("numAssets")]
    public int NumAssets;

    public BasicTreeConfig() { }

  }

  public class AdvancedTreeConfig
  {
    [JsonProperty("maxDepth")]
    public int MaxDepth;

    [JsonProperty("maxBufferSize")]
    public int MaxBufferSize;

    [JsonProperty("canopyDepth")]
    public int CanopyDepth;

    public AdvancedTreeConfig() { }

  }

  public class RecipeInputResource
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public int Amount;

    public RecipeInputResource() { }

  }

  public class RecipeInputResources
  {
    [JsonProperty("inputOne")]
    public RecipeInputResource InputOne;

    [JsonProperty("inputTwo")]
    public RecipeInputResource InputTwo;

    [JsonProperty("inputThree")]
    public RecipeInputResource InputThree;

    [JsonProperty("inputFour")]
    public RecipeInputResource InputFour;

    public RecipeInputResources() { }

  }

  public class RecipeOutputResource
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public int Amount;

    [JsonProperty("characteristics")]
    public object Characteristics;

    public RecipeOutputResource() { }

  }

  public class RecipeResources
  {
    [JsonProperty("input")]
    public RecipeInputResources Input;

    [JsonProperty("output")]
    public RecipeOutputResource Output;

    public RecipeResources() { }

  }

  public class NewMissionPoolData
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("name")]
    public string Name;

    public NewMissionPoolData() { }

  }

  public class UpdateMissionPoolData
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("missionPool")]
    public string MissionPool;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    public UpdateMissionPoolData() { }

  }

  public class NewMissionCost
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("amount")]
    public string Amount;

    public NewMissionCost() { }

  }

  public class MissionReward
  {
    [JsonProperty("kind")]
    public RewardKind Kind;

    [JsonProperty("min")]
    public string Min;

    [JsonProperty("max")]
    public string Max;

    [JsonProperty("resource")]
    public string Resource;

    public MissionReward() { }

  }

  public class NewMissionData
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("missionPool")]
    public string MissionPool;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("minXp")]
    public string MinXp;

    [JsonProperty("cost")]
    public NewMissionCost Cost;

    [JsonProperty("duration")]
    public string Duration;

    [JsonProperty("rewards")]
    public List<MissionReward> Rewards;

    public NewMissionData() { }

  }

  public class UpdateMissionData
  {
    [JsonProperty("mission")]
    public string Mission;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("minXp")]
    public string MinXp;

    [JsonProperty("cost")]
    public NewMissionCost Cost;

    [JsonProperty("duration")]
    public string Duration;

    [JsonProperty("removeAllRewards")]
    public bool RemoveAllRewards;

    [JsonProperty("addRewards")]
    public List<MissionReward> AddRewards;

    [JsonProperty("removeRewardIndices")]
    public List<int> RemoveRewardIndices;

    public UpdateMissionData() { }

  }

  public class ParticipateOnMissionData
  {
    [JsonProperty("mission")]
    public string Mission;

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    public ParticipateOnMissionData() { }

  }

  public class RecallFromMissionData
  {
    [JsonProperty("mission")]
    public string Mission;

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    public RecallFromMissionData() { }

  }

  public class CreateBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("startTime")]
    public int StartTime;

    [JsonProperty("endTime")]
    public int EndTime;

    [JsonProperty("badgeIndex")]
    public int BadgeIndex;

    [JsonProperty("condition")]
    public BadgesCondition Condition;

    public CreateBadgeCriteriaInput() { }

  }

  public class ClaimBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress;

    [JsonProperty("profileAddress")]
    public string ProfileAddress;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("criteriaIndex")]
    public int CriteriaIndex;

    [JsonProperty("proof")]
    public BadgesCondition Proof;

    public ClaimBadgeCriteriaInput() { }

  }

  public class UpdateBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("criteriaIndex")]
    public int CriteriaIndex;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("startTime")]
    public int StartTime;

    [JsonProperty("endTime")]
    public int EndTime;

    [JsonProperty("condition")]
    public BadgesCondition Condition;

    public UpdateBadgeCriteriaInput() { }

  }

  public class SendTransactionsOptions
  {
    [JsonProperty("commitment")]
    public string Commitment;

    [JsonProperty("skipPreflight")]
    public bool SkipPreflight;

    public SendTransactionsOptions() { }

  }

  public class SendTransactionBundlesOptions
  {
    [JsonProperty("commitment")]
    public string Commitment;

    [JsonProperty("skipPreflight")]
    public bool SkipPreflight;

    [JsonProperty("bundles")]
    public TransactionBundlesOptions Bundles;

    public SendTransactionBundlesOptions() { }

  }

  public class TransactionBundlesOptions
  {
    [JsonProperty("bundleSize")]
    public int BundleSize;

    [JsonProperty("firstBundleSize")]
    public int FirstBundleSize;

    [JsonProperty("lastBundleSize")]
    public int LastBundleSize;

    public TransactionBundlesOptions() { }

  }

  public class InitResourceInput
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("symbol")]
    public string Symbol;

    [JsonProperty("uri")]
    public string Uri;

    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("storage")]
    public ResourceStorageEnum Storage;

    public InitResourceInput() { }

  }

  public class IngredientsInput
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress;

    [JsonProperty("amount")]
    public string Amount;

    public IngredientsInput() { }

  }

  public class MealInput
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress;

    [JsonProperty("amount")]
    public string Amount;

    public MealInput() { }

  }

  public class ImportResourceInput
  {
    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("storage")]
    public ResourceStorageEnum Storage;

    [JsonProperty("custody")]
    public ImportResourceInputCustodyInput Custody;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    public ImportResourceInput() { }

  }

  public class ImportResourceInputCustodyInput
  {
    [JsonProperty("supply")]
    public string Supply;

    [JsonProperty("burnerDestination")]
    public string BurnerDestination;

    public ImportResourceInputCustodyInput() { }

  }

}

