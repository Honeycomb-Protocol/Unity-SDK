using Newtonsoft.Json;
using System.Collections.Generic;

using HplEdgeClient.Enums;

namespace HplEdgeClient.Inputs
{
  public class CharacterTraitInput
  {
    [JsonProperty("layer")]
    public string Layer { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    public CharacterTraitInput() { }

  }

  public class MintAsInput
  {
    [JsonProperty("kind")]
    public MintAsKind Kind { get; set; }

    [JsonProperty("mplBubblegum")]
    public MintAsMplBubblegumInput MplBubblegum { get; set; }

    public MintAsInput() { }

  }

  public class CharacterCooldownInput
  {
    [JsonProperty("ejection")]
    public int Ejection { get; set; }

    public CharacterCooldownInput() { }

  }

  public class MintAsMplBubblegumInput
  {
    [JsonProperty("maxDepth")]
    public int MaxDepth { get; set; }

    [JsonProperty("maxBufferSize")]
    public int MaxBufferSize { get; set; }

    public MintAsMplBubblegumInput() { }

  }

  public class CharacterConfigInput
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("criterias")]
    public List<AssetCriteriaInput> Criterias { get; set; }

    [JsonProperty("assemblerConfigInput")]
    public AssemblerConfigInput AssemblerConfigInput { get; set; }

    public CharacterConfigInput() { }

  }

  public class AssemblerConfigInput
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("creators")]
    public List<NftCreatorInput> Creators { get; set; }

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints { get; set; }

    [JsonProperty("collectionName")]
    public string CollectionName { get; set; }

    public AssemblerConfigInput() { }

  }

  public class NftCreatorInput
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("share")]
    public int Share { get; set; }

    public NftCreatorInput() { }

  }

  public class AssetCriteriaInput
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public string Params { get; set; }

    public AssetCriteriaInput() { }

  }

  public class CharactersFilter
  {
    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("source")]
    public CharacterSourceFilter Source { get; set; }

    [JsonProperty("usedBy")]
    public CharacterUsedByFilter UsedBy { get; set; }

    public CharactersFilter() { }

  }

  public class CharacterSourceFilter
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public CharacterSourceParamsFilter Params { get; set; }

    public CharacterSourceFilter() { }

  }

  public class CharacterSourceParamsFilter
  {
    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("criteria")]
    public AssetCriteriaFilter Criteria { get; set; }

    [JsonProperty("is_compressed")]
    public bool? Is_compressed { get; set; }

    public CharacterSourceParamsFilter() { }

  }

  public class AssetCriteriaFilter
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public string Params { get; set; }

    public AssetCriteriaFilter() { }

  }

  public class CharacterUsedByFilter
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("params")]
    public CharacterUsedByParamsFilter Params { get; set; }

    public CharacterUsedByFilter() { }

  }

  public class CharacterUsedByParamsFilter
  {
    [JsonProperty("pool")]
    public string Pool { get; set; }

    [JsonProperty("staker")]
    public string Staker { get; set; }

    [JsonProperty("stakedAt")]
    public int? StakedAt { get; set; }

    [JsonProperty("claimedAt")]
    public int? ClaimedAt { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("rewards")]
    public List<EarnedRewardsFilter> Rewards { get; set; }

    [JsonProperty("endTime")]
    public int? EndTime { get; set; }

    [JsonProperty("rewardsCollected")]
    public bool? RewardsCollected { get; set; }

    [JsonProperty("role")]
    public GuildRoleFilter Role { get; set; }

    [JsonProperty("order")]
    public int? Order { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("user")]
    public string User { get; set; }

    public CharacterUsedByParamsFilter() { }

  }

  public class EarnedRewardsFilter
  {
    [JsonProperty("delta")]
    public int? Delta { get; set; }

    [JsonProperty("rewardIdx")]
    public int? RewardIdx { get; set; }

    public EarnedRewardsFilter() { }

  }

  public class UsedByGuildFilter
  {
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("role")]
    public GuildRoleFilter Role { get; set; }

    [JsonProperty("order")]
    public int? Order { get; set; }

    public UsedByGuildFilter() { }

  }

  public class GuildRoleFilter
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public GuildRoleFilter() { }

  }

  public class CivicInfoInput
  {
    [JsonProperty("gatekeeperNetwork")]
    public CivicGateway GatekeeperNetwork { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    public CivicInfoInput() { }

  }

  public class UserInfoInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("pfp")]
    public string Pfp { get; set; }

    public UserInfoInput() { }

  }

  public class PartialUserInfoInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("pfp")]
    public string Pfp { get; set; }

    public PartialUserInfoInput() { }

  }

  public class UpdateWalletInput
  {
    [JsonProperty("add")]
    public List<string> Add { get; set; }

    [JsonProperty("remove")]
    public List<string> Remove { get; set; }

    public UpdateWalletInput() { }

  }

  public class AssociatedProgramInput
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("trustedActions")]
    public List<SerializableActionsInput> TrustedActions { get; set; }

    public AssociatedProgramInput() { }

  }

  public class SerializableActionsInput
  {
    [JsonProperty("kind")]
    public string Kind { get; set; }

    public SerializableActionsInput() { }

  }

  public class ProfileDataConfigInput
  {
    [JsonProperty("achievements")]
    public List<string> Achievements { get; set; }

    [JsonProperty("customDataFields")]
    public List<string> CustomDataFields { get; set; }

    public ProfileDataConfigInput() { }

  }

  public class ProfileInfoInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("pfp")]
    public string Pfp { get; set; }

    public ProfileInfoInput() { }

  }

  public class CustomDataInput
  {
    [JsonProperty("add")]
    public object Add { get; set; }

    [JsonProperty("remove")]
    public List<string> Remove { get; set; }

    public CustomDataInput() { }

  }

  public class PlatformDataInput
  {
    [JsonProperty("custom")]
    public CustomDataInput Custom { get; set; }

    [JsonProperty("addXp")]
    public string AddXp { get; set; }

    [JsonProperty("addAchievements")]
    public List<int> AddAchievements { get; set; }

    public PlatformDataInput() { }

  }

  public class ServiceDelegationInput
  {
    [JsonProperty("HiveControl")]
    public List<ServiceDelegationHiveControl> HiveControl { get; set; }

    [JsonProperty("CharacterManager")]
    public List<ServiceDelegationCharacterManager> CharacterManager { get; set; }

    [JsonProperty("ResourceManager")]
    public List<ServiceDelegationResourceManager> ResourceManager { get; set; }

    [JsonProperty("NectarStaking")]
    public List<ServiceDelegationNectarStaking> NectarStaking { get; set; }

    [JsonProperty("NectarMissions")]
    public List<ServiceDelegationNectarMissions> NectarMissions { get; set; }

    [JsonProperty("BuzzGuild")]
    public List<ServiceDelegationBuzzGuild> BuzzGuild { get; set; }

    public ServiceDelegationInput() { }

  }

  public class ServiceDelegationHiveControl
  {
    [JsonProperty("permission")]
    public HiveControlPermissionInput Permission { get; set; }

    public ServiceDelegationHiveControl() { }

  }

  public class ServiceDelegationCharacterManager
  {
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("permission")]
    public CharacterManagerPermissionInput Permission { get; set; }

    public ServiceDelegationCharacterManager() { }

  }

  public class ServiceDelegationResourceManager
  {
    [JsonProperty("permission")]
    public ResourceManagerPermissionInput Permission { get; set; }

    public ServiceDelegationResourceManager() { }

  }

  public class ServiceDelegationNectarStaking
  {
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("permission")]
    public NectarStakingPermissionInput Permission { get; set; }

    public ServiceDelegationNectarStaking() { }

  }

  public class ServiceDelegationNectarMissions
  {
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("permission")]
    public NectarMissionsPermissionInput Permission { get; set; }

    public ServiceDelegationNectarMissions() { }

  }

  public class ServiceDelegationBuzzGuild
  {
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("permission")]
    public BuzzGuildPermissionInput Permission { get; set; }

    public ServiceDelegationBuzzGuild() { }

  }

  public class ModifyServiceDelegationInput
  {
    [JsonProperty("HiveControl")]
    public ServiceDelegationHiveControl HiveControl { get; set; }

    [JsonProperty("CharacterManager")]
    public ServiceDelegationCharacterManager CharacterManager { get; set; }

    [JsonProperty("ResourceManager")]
    public ServiceDelegationResourceManager ResourceManager { get; set; }

    [JsonProperty("NectarStaking")]
    public ServiceDelegationNectarStaking NectarStaking { get; set; }

    [JsonProperty("NectarMissions")]
    public ServiceDelegationNectarMissions NectarMissions { get; set; }

    [JsonProperty("BuzzGuild")]
    public ServiceDelegationBuzzGuild BuzzGuild { get; set; }

    public ModifyServiceDelegationInput() { }

  }

  public class ModifyDelegationInput
  {
    [JsonProperty("delegation")]
    public ModifyServiceDelegationInput Delegation { get; set; }

    [JsonProperty("index")]
    public int? Index { get; set; }

    public ModifyDelegationInput() { }

  }

  public class UpdateMissionInput
  {
    [JsonProperty("cost")]
    public NewMissionCost Cost { get; set; }

    [JsonProperty("minXp")]
    public string MinXp { get; set; }

    [JsonProperty("duration")]
    public string Duration { get; set; }

    [JsonProperty("removeRewards")]
    public List<int> RemoveRewards { get; set; }

    [JsonProperty("newRewards")]
    public List<MissionReward> NewRewards { get; set; }

    [JsonProperty("updateRewards")]
    public List<MissionReward> UpdateRewards { get; set; }

    public UpdateMissionInput() { }

  }

  public class CreateStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration { get; set; }

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration { get; set; }

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration { get; set; }

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration { get; set; }

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration { get; set; }

    [JsonProperty("resetStakeDuration")]
    public bool ResetStakeDuration { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("lockType")]
    public LockTypeEnum LockType { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    public CreateStakingPoolMetadataInput() { }

  }

  public class UpdateStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration { get; set; }

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration { get; set; }

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration { get; set; }

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration { get; set; }

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration { get; set; }

    [JsonProperty("resetStakeDuration")]
    public bool? ResetStakeDuration { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    public UpdateStakingPoolMetadataInput() { }

  }

  public class MultiplierTypeInput
  {
    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration { get; set; }

    [JsonProperty("minNftCount")]
    public string MinNftCount { get; set; }

    [JsonProperty("creator")]
    public string Creator { get; set; }

    [JsonProperty("collection")]
    public string Collection { get; set; }

    public MultiplierTypeInput() { }

  }

  public class AddMultiplierMetadataInput
  {
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("type")]
    public MultiplierTypeInput Type { get; set; }

    public AddMultiplierMetadataInput() { }

  }

  public class InitStakingMultiplierMetadataInput
  {
    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("multipliers")]
    public List<AddMultiplierMetadataInput> Multipliers { get; set; }

    public InitStakingMultiplierMetadataInput() { }

  }

  public class CreateSplStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("minStakeDurationSecs")]
    public string MinStakeDurationSecs { get; set; }

    [JsonProperty("maxStakeDurationSecs")]
    public string MaxStakeDurationSecs { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    public CreateSplStakingPoolMetadataInput() { }

  }

  public class UpdateSplStakingPoolMetadataInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("minStakeDurationSecs")]
    public string MinStakeDurationSecs { get; set; }

    [JsonProperty("maxStakeDurationSecs")]
    public string MaxStakeDurationSecs { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    public UpdateSplStakingPoolMetadataInput() { }

  }

  public class AddRemoveRewardsFromRewardPoolActionInput
  {
    [JsonProperty("add")]
    public string Add { get; set; }

    [JsonProperty("remove")]
    public string Remove { get; set; }

    public AddRemoveRewardsFromRewardPoolActionInput() { }

  }

  public class CreateSplRewardPoolArgsInput
  {
    [JsonProperty("ApyConfig")]
    public RewardPoolConfigApyInput ApyConfig { get; set; }

    public CreateSplRewardPoolArgsInput() { }

  }

  public class RewardPoolConfigApyInput
  {
    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration { get; set; }

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration { get; set; }

    public RewardPoolConfigApyInput() { }

  }

  public class SplMultiplierInput
  {
    [JsonProperty("minDuration")]
    public string MinDuration { get; set; }

    [JsonProperty("minAmount")]
    public string MinAmount { get; set; }

    public SplMultiplierInput() { }

  }

  public class AddSplMultiplierMetadataInput
  {
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("type")]
    public SplMultiplierInput Type { get; set; }

    public AddSplMultiplierMetadataInput() { }

  }

  public class DisrcriminatorFilter
  {
    [JsonProperty("programId")]
    public string ProgramId { get; set; }

    [JsonProperty("accountName")]
    public string AccountName { get; set; }

    public DisrcriminatorFilter() { }

  }

  public class TreeLeaf
  {
    [JsonProperty("tree")]
    public string Tree { get; set; }

    [JsonProperty("index")]
    public string Index { get; set; }

    public TreeLeaf() { }

  }

  public class TreeSetupConfig
  {
    [JsonProperty("basic")]
    public BasicTreeConfig Basic { get; set; }

    [JsonProperty("advanced")]
    public AdvancedTreeConfig Advanced { get; set; }

    public TreeSetupConfig() { }

  }

  public class BasicTreeConfig
  {
    [JsonProperty("numAssets")]
    public int NumAssets { get; set; }

    public BasicTreeConfig() { }

  }

  public class AdvancedTreeConfig
  {
    [JsonProperty("maxDepth")]
    public int MaxDepth { get; set; }

    [JsonProperty("maxBufferSize")]
    public int MaxBufferSize { get; set; }

    [JsonProperty("canopyDepth")]
    public int CanopyDepth { get; set; }

    public AdvancedTreeConfig() { }

  }

  public class RecipeInputResource
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public int Amount { get; set; }

    public RecipeInputResource() { }

  }

  public class RecipeInputResources
  {
    [JsonProperty("inputOne")]
    public RecipeInputResource InputOne { get; set; }

    [JsonProperty("inputTwo")]
    public RecipeInputResource InputTwo { get; set; }

    [JsonProperty("inputThree")]
    public RecipeInputResource InputThree { get; set; }

    [JsonProperty("inputFour")]
    public RecipeInputResource InputFour { get; set; }

    public RecipeInputResources() { }

  }

  public class RecipeOutputResource
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public int Amount { get; set; }

    [JsonProperty("characteristics")]
    public object Characteristics { get; set; }

    public RecipeOutputResource() { }

  }

  public class RecipeResources
  {
    [JsonProperty("input")]
    public RecipeInputResources Input { get; set; }

    [JsonProperty("output")]
    public RecipeOutputResource Output { get; set; }

    public RecipeResources() { }

  }

  public class NewMissionPoolData
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    public NewMissionPoolData() { }

  }

  public class UpdateMissionPoolData
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("missionPool")]
    public string MissionPool { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    public UpdateMissionPoolData() { }

  }

  public class NewMissionCost
  {
    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    public NewMissionCost() { }

  }

  public class MissionReward
  {
    [JsonProperty("kind")]
    public RewardKind Kind { get; set; }

    [JsonProperty("min")]
    public string Min { get; set; }

    [JsonProperty("max")]
    public string Max { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    public MissionReward() { }

  }

  public class NewMissionData
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("missionPool")]
    public string MissionPool { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("minXp")]
    public string MinXp { get; set; }

    [JsonProperty("cost")]
    public NewMissionCost Cost { get; set; }

    [JsonProperty("duration")]
    public string Duration { get; set; }

    [JsonProperty("rewards")]
    public List<MissionReward> Rewards { get; set; }

    public NewMissionData() { }

  }

  public class UpdateMissionData
  {
    [JsonProperty("mission")]
    public string Mission { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("minXp")]
    public string MinXp { get; set; }

    [JsonProperty("cost")]
    public NewMissionCost Cost { get; set; }

    [JsonProperty("duration")]
    public string Duration { get; set; }

    [JsonProperty("removeAllRewards")]
    public bool? RemoveAllRewards { get; set; }

    [JsonProperty("addRewards")]
    public List<MissionReward> AddRewards { get; set; }

    [JsonProperty("removeRewardIndices")]
    public List<int> RemoveRewardIndices { get; set; }

    public UpdateMissionData() { }

  }

  public class ParticipateOnMissionData
  {
    [JsonProperty("mission")]
    public string Mission { get; set; }

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("userId")]
    public int? UserId { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    public ParticipateOnMissionData() { }

  }

  public class RecallFromMissionData
  {
    [JsonProperty("mission")]
    public string Mission { get; set; }

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("userId")]
    public int? UserId { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    public RecallFromMissionData() { }

  }

  public class CreateBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("startTime")]
    public int? StartTime { get; set; }

    [JsonProperty("endTime")]
    public int? EndTime { get; set; }

    [JsonProperty("badgeIndex")]
    public int BadgeIndex { get; set; }

    [JsonProperty("condition")]
    public BadgesCondition Condition { get; set; }

    public CreateBadgeCriteriaInput() { }

  }

  public class ClaimBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress { get; set; }

    [JsonProperty("profileAddress")]
    public string ProfileAddress { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("criteriaIndex")]
    public int CriteriaIndex { get; set; }

    [JsonProperty("proof")]
    public BadgesCondition Proof { get; set; }

    public ClaimBadgeCriteriaInput() { }

  }

  public class UpdateBadgeCriteriaInput
  {
    [JsonProperty("projectAddress")]
    public string ProjectAddress { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("criteriaIndex")]
    public int CriteriaIndex { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("startTime")]
    public int? StartTime { get; set; }

    [JsonProperty("endTime")]
    public int? EndTime { get; set; }

    [JsonProperty("condition")]
    public BadgesCondition Condition { get; set; }

    public UpdateBadgeCriteriaInput() { }

  }

  public class SendTransactionsOptions
  {
    [JsonProperty("commitment")]
    public string Commitment { get; set; }

    [JsonProperty("skipPreflight")]
    public bool? SkipPreflight { get; set; }

    public SendTransactionsOptions() { }

  }

  public class SendTransactionBundlesOptions
  {
    [JsonProperty("commitment")]
    public string Commitment { get; set; }

    [JsonProperty("skipPreflight")]
    public bool? SkipPreflight { get; set; }

    [JsonProperty("bundles")]
    public TransactionBundlesOptions Bundles { get; set; }

    public SendTransactionBundlesOptions() { }

  }

  public class TransactionBundlesOptions
  {
    [JsonProperty("bundleSize")]
    public int? BundleSize { get; set; }

    [JsonProperty("firstBundleSize")]
    public int? FirstBundleSize { get; set; }

    [JsonProperty("lastBundleSize")]
    public int? LastBundleSize { get; set; }

    public TransactionBundlesOptions() { }

  }

  public class InitResourceInput
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("uri")]
    public string Uri { get; set; }

    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("storage")]
    public ResourceStorageEnum Storage { get; set; }

    public InitResourceInput() { }

  }

  public class IngredientsInput
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    public IngredientsInput() { }

  }

  public class MealInput
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    public MealInput() { }

  }

  public class ImportResourceInput
  {
    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("storage")]
    public ResourceStorageEnum Storage { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("custody")]
    public ImportResourceInputCustodyInput Custody { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    public ImportResourceInput() { }

  }

  public class ImportResourceInputCustodyInput
  {
    [JsonProperty("supply")]
    public string Supply { get; set; }

    [JsonProperty("burnerDestination")]
    public string BurnerDestination { get; set; }

    public ImportResourceInputCustodyInput() { }

  }

}

